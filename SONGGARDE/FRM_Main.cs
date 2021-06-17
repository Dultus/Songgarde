using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using NAudio.Wave;
using System.Runtime.InteropServices;
using Encoder = System.Drawing.Imaging.Encoder;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Diagnostics;
using PaintDotNet;
using DdsFileTypePlus;
using System.IO.Compression;

namespace SONGGARDE
{
    public partial class FRM_Main : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );



        public static bool bNoReminder = false;
        public static bool bCloseAfterYes;

        private string sVersion = "0.0.1";
        private string sOnlineVersion;
        public string sOrigBGImagePath, sOrigTitleMusicPath, sExtension;
        public string sAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\STAM-C";

        public static Settings m_Settings = new Settings();
        private List<string> lstAllowedImageExtensions = new List<string> { ".png", ".jpg", ".jpeg", ".gif" };
        private List<string> lstAllowedMusicExtensions = new List<string> { ".wav", ".mp3" };

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public FRM_Main()
        {
            if (!Directory.Exists(sAppData + @"\Packages"))
            {
                Directory.CreateDirectory(sAppData + @"\Packages");
            }

            if (!File.Exists(sAppData + @"\Settings.cfg"))
            {
                if (!Directory.Exists(sAppData + @"\Packages"))
                {
                    Directory.CreateDirectory(sAppData);
                }
                XmlSerializer xmlSaver = new XmlSerializer(typeof(Settings));
                TextWriter writer = new StreamWriter(sAppData + @"\Settings.cfg");

                //Ordner abfragen
                m_Settings.NoReminder = false;
                m_Settings.SkyrimPath = "";
                m_Settings.NoReminderVersion = "";
                xmlSaver.Serialize(writer, m_Settings);
                writer.Close();
            }



            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "Settings";
            xRoot.IsNullable = true;
            XmlSerializer xmlLoader = new XmlSerializer(typeof(Settings), xRoot);
            using (XmlReader reader = XmlReader.Create(sAppData + @"\settings.cfg"))
            {
                m_Settings = (Settings)xmlLoader.Deserialize(reader);
            }
            //Load XML - assign Variables
            //Check Version
            var webRequest = WebRequest.Create("https://raw.githubusercontent.com/Dultus/Songgarde/master/Version");

            using (var response = webRequest.GetResponse())
            using (var content = response.GetResponseStream())
            using (var reader = new StreamReader(content))
            {
                sOnlineVersion = reader.ReadToEnd().Trim();
            }
            if (sOnlineVersion.Trim() != sVersion)
            {
                if (!m_Settings.NoReminder || m_Settings.NoReminderVersion != sVersion)
                    using (FRM_Update update = new FRM_Update())
                    {
                        update.sVersion = this.sVersion;
                        update.sOnlineVersion = this.sOnlineVersion;
                        update.ShowDialog();
                    }
            }
            if (m_Settings.SkyrimPath == "")
            {
                MessageBox.Show("New!");
            }
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            UpdateImports();
            LBL_Notifications.Text = "STAM-C Loaded.";
            if (File.Exists(sAppData + @"\TitleImage.jpg"))
            {
                using (FileStream stream = new FileStream(sAppData + @"\TitleImage.jpg", FileMode.Open, FileAccess.Read))
                {
                    PB_Preview.BackgroundImage = Image.FromStream(stream);
                }
            }
            TB_SkyrimPath.Text = m_Settings.SkyrimPath;
            PB_Preview.Controls.Add(PB_Play);
            PB_Play.Padding = new Padding(30);
            PB_Play.Dock = DockStyle.Fill;
        }
        private void UpdateImports()
        {
            CB_STAM.Items.Clear();
            foreach (var filename in Directory.GetFiles(sAppData + @"\Packages"))
            {
                if (System.IO.Path.GetExtension(filename).Equals(".STAM", StringComparison.OrdinalIgnoreCase))
                {
                    CB_STAM.Items.Add(Path.GetFileNameWithoutExtension(filename));
                    CB_STAM.SelectedIndex = 0;
                }
            }
        }
        #region ChangeBackgroundImage
        private void ChangeBackgroundImage_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void ChangeBackgroundImage_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string file = files[0];
            sExtension = System.IO.Path.GetExtension(file);
            if (lstAllowedImageExtensions.FindIndex(x => x.Equals(sExtension, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                sOrigBGImagePath = files[0];
                SetLabelBackgroundImage();
                MessageBox.Show("Image added and applied to the game!");
                LBL_Notifications.Text = "Startup image set.";
            }
            else
            {
                MessageBox.Show("Only following filetypes are allowed:\n.PNG\n.JPG\n.JPEG\n.GIF (Animations not supported)");
            }
        }
        private void ChangeBackgroundImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image File|*.png;*.jpg;*.jpeg;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    sExtension = System.IO.Path.GetExtension(ofd.FileName);
                    if (lstAllowedImageExtensions.FindIndex(x => x.Equals(sExtension, StringComparison.OrdinalIgnoreCase)) != -1)
                    {
                        sOrigBGImagePath = ofd.FileName;
                        SetLabelBackgroundImage();
                        LBL_Notifications.Text = "Startup image set.";
                    }
                }
            }
        }
        private void SetLabelBackgroundImage()
        {
            LBL_Backgroundimage.Visible = true;
            Directory.CreateDirectory(m_Settings.SkyrimPath + @"\Data\textures\interface\objects");
            PB_Preview.BackgroundImage = null;
            LBL_Backgroundimage.Text = Path.GetFileName(sOrigBGImagePath);
            //File.Copy(sOrigBGImagePath, sAppData + @"\TitleImage.jpg", true);

            File.Delete(sAppData + @"\TitleImage.jpg");
            using (FileStream stream = new FileStream(sOrigBGImagePath, FileMode.Open, FileAccess.Read))
            {
                using (Image img = Image.FromStream(stream))
                {
                    img.Save(sAppData + @"\TitleImage.jpg", ImageFormat.Jpeg);
                }
            }
            using (FileStream stream = new FileStream(sAppData + @"\TitleImage.jpg", FileMode.Open, FileAccess.Read))
            {
                PB_Preview.BackgroundImage = Image.FromStream(stream);
                ConvertImages();
            }
        }
        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
        private void ConvertImages()
        {
            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
            Encoder myEncoder = Encoder.Quality;


            EncoderParameters myEncoderParameters = new EncoderParameters(1);
            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 100L);
            myEncoderParameters.Param[0] = myEncoderParameter;





            Bitmap imgPhoto = new Bitmap(2048, 2048);
            using (Graphics graphic = Graphics.FromImage(imgPhoto))
            {
                // Crop and resize the image.
                graphic.Clear(Color.Black);
                Rectangle destination = new Rectangle(0, 0, 2048, 2048);
                graphic.DrawImage(imgPhoto, destination, 0, 0, 2048, 2048, GraphicsUnit.Pixel);
            }
            int phWidth = imgPhoto.Width;
            int phHeight = imgPhoto.Height;
            using (Bitmap bmPhoto = new Bitmap(phWidth, phHeight, PixelFormat.Format24bppRgb))
            {
                var dpiX = bmPhoto.HorizontalResolution;
                var dpiY = bmPhoto.VerticalResolution;

                imgPhoto.SetResolution(dpiX, dpiY);


                using (FileStream stream = new FileStream(sAppData + @"\TitleImage.jpg", FileMode.Open, FileAccess.Read))
                {
                    using (Bitmap imgWatermark = new Bitmap((Bitmap)Image.FromStream(stream), new Size(1987, 1084)))
                    {
                        int wmWidth = imgWatermark.Width;
                        int wmHeight = imgWatermark.Height;
                        imgWatermark.SetResolution(dpiX, dpiY);

                        using (Bitmap bmWatermark = new Bitmap(bmPhoto))
                        {

                            bmWatermark.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);

                            using (Graphics grWatermark = Graphics.FromImage(bmWatermark))
                            {

                                int xPosOfWm = 3;
                                int yPosOfWm = 328;

                                grWatermark.DrawImage(imgWatermark, new Rectangle(xPosOfWm, yPosOfWm, wmWidth, wmHeight), 0, 0, wmWidth, wmHeight, GraphicsUnit.Pixel);



                                var stream1 = new MemoryStream();

                                bmWatermark.Save(stream1, ImageFormat.Jpeg);
                                stream1.Position = 0;

                                Surface processedSurface = Surface.CopyFromBitmap(bmWatermark);

                                System.IO.FileStream fileStream = new System.IO.FileStream(
                                    sAppData + @"\mainmenuwallpaper.dds",
                                    System.IO.FileMode.Create);
                                DdsFile.Save(
                                   fileStream,
                                   DdsFileFormat.BC6H,
                                   DdsErrorMetric.Perceptual,
                                   BC7CompressionMode.Fast,
                                   cubeMap: true,
                                   generateMipmaps: true,
                                   ResamplingAlgorithm.Bilinear,
                                   processedSurface,
                                   ProgressChanged);
                                
                                fileStream.Close();
                            }

                            imgPhoto.Dispose();

                            File.Copy(sAppData + @"\mainmenuwallpaper.dds", m_Settings.SkyrimPath + @"\Data\textures\interface\objects\mainmenuwallpaper.dds", true);

                        }
                    }
                }
            }
        }

        private void ProgressChanged(object sender, PaintDotNet.ProgressEventArgs e)
        {
            //throw new NotImplementedException();
        }
        #endregion
        #region ChangeTitleMusic
        private void ChangeTitleMusic_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string file = files[0];
            sExtension = System.IO.Path.GetExtension(file);
            if (lstAllowedMusicExtensions.FindIndex(x => x.Equals(sExtension, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                sOrigTitleMusicPath = files[0];
                SetLabelMusic();
            }
            else
            {
                MessageBox.Show("Only following filetypes are allowed:\n.MP3\n.WAV");
                LBL_Notifications.Text = "Startup music set.";
            }
        }

        private void ChangeTitleMusic_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void FRM_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Settings));
            TextWriter writer = new StreamWriter(sAppData + @"\Settings.cfg");
            xmlSerializer.Serialize(writer, m_Settings);
        }

        private void FRM_Main_Load(object sender, EventArgs e)
        {
            if (bCloseAfterYes)
            {
                this.Close();
                Application.Exit();
            }
            //CB_Resolution.SelectedIndex = 0;
            /*
            var packageFilePath = AppDomain.CurrentDomain.BaseDirectory + "Packs\\" + CB_NewImagePacksFromFolder.Text + ".pkg";
            var filePackageReader = new FilePackageReader(packageFilePath);
            var PictureNamePictureContentDictionary = filePackageReader.GetPictureNamePictureContentDictionary();

            foreach (var keyValuePair in PictureNamePictureContentDictionary)
            {
                if (keyValuePair.Key == "PACK_ICON.png")
                {
                    PB_IconPackIcon.BackgroundImage = keyValuePair.Value;
                    break;
                }
            }
            var filenameFileContentDictionary = filePackageReader.GetFileNameFileContentDictionary();
            foreach (var keyValuePair in filenameFileContentDictionary)
            {
                if (keyValuePair.Key == "CONTENT.txt")
                {
                    label2.Text = keyValuePair.Value;
                    break;
                }
            }*/
        }

        private void PB_Play_Click(object sender, EventArgs e)
        {
            using (FRM_Preview preview = new FRM_Preview())
            {
                // preview.m_eResolution = (FRM_Preview.eResolution)CB_Resolution.SelectedIndex;
                preview.ShowDialog();
            }
        }

        private void BTN_ChangeDirectory_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog ofd = new CommonOpenFileDialog())
            {
                ofd.IsFolderPicker = true;
                if (ofd.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    TB_SkyrimPath.Text = ofd.FileName;
                }
            }
            m_Settings.SkyrimPath = TB_SkyrimPath.Text;
        }
        private void TB_SkyrimPath_TextChanged(object sender, EventArgs e)
        {
            m_Settings.SkyrimPath = TB_SkyrimPath.Text;
            LBL_Notifications.Text = "Skyrim Path set.";
        }

        private void PNL_TopWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nexuswebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.nexusmods.com/skyrimspecialedition/mods/41782");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.Dultus.com");
        }

        private void LBL_Backgroundimage_Resize(object sender, EventArgs e)
        {
            if ((sender as Label).Size.Width > 463)
            {
                (sender as Label).AutoSize = false;
                (sender as Label).Width = 463;
            }
            else
            {
                (sender as Label).AutoSize = true;
            }
        }

        private void BTN_ExportSTAM_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(sAppData + "/Packages/temp/data/music/special");
            Directory.CreateDirectory(sAppData + "/Packages/temp/data/textures/interface/objects");


            File.Copy(sAppData + "/mainmenuwallpaper.dds", sAppData + "/Packages/temp/data/textures/interface/objects/mainmenuwallpaper.dds");
            File.Copy(sAppData + "/TitleImage.jpg", sAppData + "/Packages/temp/TitleImage.jpg");
            File.Copy(sAppData + "/TitleMusic.wav", sAppData + "/Packages/temp/data/music/special/mus_maintheme.wav");



            ZipFile.CreateFromDirectory(sAppData + "/Packages/temp", sAppData + "/Packages/STAM-C_PACKAGE_" + DateTime.Now.Ticks.ToString() + ".STAM");
            Directory.Delete(sAppData + "/Packages/temp", true);
            UpdateImports();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CMS_Main.Show(Cursor.Position);
        }

        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ChangeTitleMusic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Sound File|*.mp3;*.wav";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    sExtension = System.IO.Path.GetExtension(ofd.FileName);
                    if (lstAllowedImageExtensions.FindIndex(x => x.Equals(sExtension, StringComparison.OrdinalIgnoreCase)) != -1)
                    {
                        sOrigTitleMusicPath = ofd.FileName;
                        SetLabelMusic();
                        LBL_Notifications.Text = "Startup music set.";
                    }
                }
            }

        }
        private void SetLabelMusic()
        {
            LBL_TitleMusic.Visible = true;
            LBL_TitleMusic.Text = Path.GetFileName(sOrigTitleMusicPath);
            File.Copy(sOrigTitleMusicPath, sAppData + @"\TitleMusic" + sExtension, true);
            if (sExtension.Equals(".mp3", StringComparison.OrdinalIgnoreCase))
            {
                using (Mp3FileReader mp3 = new Mp3FileReader(sAppData + @"\TitleMusic" + sExtension))
                {
                    using (WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(mp3))
                    {
                        WaveFileWriter.CreateWaveFile(sAppData + @"\TitleMusic.wav", pcm);
                    }
                }
            }
            Directory.CreateDirectory(m_Settings.SkyrimPath + @"\Data\music\special");
            File.Copy(sAppData + @"\TitleMusic.wav", m_Settings.SkyrimPath + @"\Data\music\special\mus_maintheme.wav", true);
        }
        #endregion
    }
}
