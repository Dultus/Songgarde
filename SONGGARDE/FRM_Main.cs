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



        public static bool bNoReminder = false;
        public static bool bCloseAfterYes;

        private string sVersion = "1.0.0";
        private string sOnlineVersion;
        public menureplacer bannerinstallmode = 0;
        public string sOrigBGImagePath, sOrigTitleMusicPath, sExtension;
        public string sAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\SONGGARDE";

        public static Settings m_Settings = new Settings();
        private List<string> lstAllowedImageExtensions = new List<string> { ".png", ".jpg", ".jpeg", ".gif" };
        private List<string> lstAllowedMusicExtensions = new List<string> { ".wav", ".mp3" };

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
             //   FRM_Setup setup = new FRM_Setup();
             //   setup.ShowDialog();
            }
            InitializeComponent();
            UpdateImports();
            if (File.Exists(sAppData + @"\TitleImage.jpg"))
            {
                using (FileStream stream = new FileStream(sAppData + @"\TitleImage.jpg", FileMode.Open, FileAccess.Read))
                {
                    PB_Preview.BackgroundImage = Image.FromStream(stream);
                    LBL_Preview.Visible = true;
                }
            }
            TB_SkyrimPath.Text = m_Settings.SkyrimPath;
            PB_Preview.Controls.Add(PB_Play);
            PB_Play.Padding = new Padding(30);
            PB_Play.Dock = DockStyle.Fill;

            CFormBuilder.notify("SONGGARDE loaded.", this);
        }
        private void UpdateImports()
        {
            CB_STAM.Items.Clear();
            foreach (var filename in Directory.GetFiles(sAppData + @"\Packages"))
            {
                if (System.IO.Path.GetExtension(filename).Equals(".zip", StringComparison.OrdinalIgnoreCase))
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
                CFormBuilder.notify("Startup image set.", this);
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
                    }
                }
            }
        }
        private void SetLabelBackgroundImage()
        {
            LBL_Backgroundimage.Visible = true;
            Directory.CreateDirectory(m_Settings.SkyrimPath + @"\Data\textures\interface\objects");
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
                LBL_Preview.Visible = true;
                ConvertImages();
            }
            if (!chkFog.Checked && !chkSkyrimLogo.Checked)
            {
                CFormBuilder.notify("Startup image set. (No fog, no logo)", this);
                bannerinstallmode = menureplacer.nofognologo;
            }
            else if (chkFog.Checked && !chkSkyrimLogo.Checked)
            {
                CFormBuilder.notify("Startup image set. (With fog, no logo)", this);
                bannerinstallmode = menureplacer.nologo;
            }
            else if (!chkFog.Checked && chkSkyrimLogo.Checked)
            {
                CFormBuilder.notify("Startup image set. (No fog, with logo)", this);
                bannerinstallmode = menureplacer.nofog;
            }
            else
            {
                CFormBuilder.notify("Startup image set. (With fog, with logo)", this);
                bannerinstallmode = menureplacer.fogandlogo;
            }
            pbSkyrimLogo.Refresh();
            pbFog.Refresh();
        }
        private void setfogorlogo()
        {
            if (bannerinstallmode == menureplacer.nofognologo)
            {
                File.Copy(@"interface\nofog.nif", m_Settings.SkyrimPath + @"\Data\meshes\interface\intmenufogparticles.nif", true);
                File.Copy(@"interface\banner.nif", m_Settings.SkyrimPath + @"\Data\meshes\interface\logo\logo.nif", true);
            }
            else if (bannerinstallmode == menureplacer.nofog)
            {
                File.Copy(@"interface\nofog.nif", m_Settings.SkyrimPath + @"\Data\meshes\interface\intmenufogparticles.nif", true);
                File.Copy(@"interface\logo.nif", m_Settings.SkyrimPath + @"\Data\meshes\interface\logo\logo.nif", true);
            }
            else if (bannerinstallmode == menureplacer.nologo)
            {
                if (File.Exists(m_Settings.SkyrimPath + @"\Data\meshes\interface\intmenufogparticles.nif"))
                    File.Delete(m_Settings.SkyrimPath + @"\Data\meshes\interface\intmenufogparticles.nif");
                File.Copy(@"interface\banner.nif", m_Settings.SkyrimPath + @"\Data\meshes\interface\logo\logo.nif", true);
            }
            else if (bannerinstallmode == menureplacer.fogandlogo)
            {
                if (File.Exists(m_Settings.SkyrimPath + @"\Data\meshes\interface\intmenufogparticles.nif"))
                    File.Delete(m_Settings.SkyrimPath + @"\Data\meshes\interface\intmenufogparticles.nif");
                File.Copy(@"interface\logo.nif", m_Settings.SkyrimPath + @"\Data\meshes\interface\logo\logo.nif", true);
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
                    using (Bitmap imgWatermark = new Bitmap((Bitmap)Image.FromStream(stream), new Size(2048, 1154)))
                    {
                        int wmWidth = imgWatermark.Width;
                        int wmHeight = imgWatermark.Height;
                        imgWatermark.SetResolution(dpiX, dpiY);

                        using (Bitmap bmWatermark = new Bitmap(bmPhoto))
                        {

                            bmWatermark.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);

                            using (Graphics grWatermark = Graphics.FromImage(bmWatermark))
                            {

                                int xPosOfWm = 0;
                                int yPosOfWm = 322;

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
                CFormBuilder.notify("Startup music set.", this);
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
            CFormBuilder.round(this);
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
                m_Settings.SkyrimPath = TB_SkyrimPath.Text;
                CFormBuilder.notify("Skyrim Path set.", this);
            }
        }

        private void PNL_TopWindow_MouseMove(object sender, MouseEventArgs e)
        {
            CFormBuilder.move(this, e);
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
            if (File.Exists(sAppData + "/mus_maintheme.wav"))
                Directory.CreateDirectory(sAppData + "/Packages/temp/data/music/special");

            if (File.Exists(sAppData + "/mainmenuwallpaper.dds"))
                Directory.CreateDirectory(sAppData + "/Packages/temp/data/textures/interface/objects");


            if (File.Exists(sAppData + "/mainmenuwallpaper.dds"))
                File.Copy(sAppData + "/mainmenuwallpaper.dds", sAppData + "/Packages/temp/data/textures/interface/objects/mainmenuwallpaper.dds", true);
                File.Copy(sAppData + "/TitleImage.jpg", sAppData + "/Packages/temp/TitleImage.jpg", true);

            if (File.Exists(sAppData + "/mus_maintheme.wav"))
                File.Copy(sAppData + "/TitleMusic.wav", sAppData + "/Packages/temp/data/music/special/mus_maintheme.wav", true);

            if (chkSkyrimLogo.Checked)
            {
                Directory.CreateDirectory(sAppData + "/Packages/temp/Data/meshes/interface/logo/");
                File.Copy(@"interface\logo.nif", sAppData + "/Packages/temp/Data/meshes/interface/logo/logo.nif", true);
            }
            if (!chkFog.Checked)
            {
                Directory.CreateDirectory(sAppData + "/Packages/temp/data/meshes/interface/");
                File.Copy(@"interface\nofog.nif", sAppData + "/Packages/temp/data/meshes/interface/intmenufogparticles.nif", true);
            }
            ZipFile.CreateFromDirectory(sAppData + "/Packages/temp", sAppData + "/Packages/SONGGARDE_" + DateTime.Now.Ticks.ToString() + ".zip");
            Directory.Delete(sAppData + "/Packages/temp", true);
            UpdateImports();
            Process.Start(sAppData + "/Packages");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CMS_Main.Show(Cursor.Position);
        }

        private void setupFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Setup setup = new FRM_Setup();
            setup.ShowDialog();
        }

        private void chkFog_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFog.Checked)
            {
                pbSkyrimLogo.Refresh();
                pbFog.Refresh();
                pbFog.Visible = true;
            }
            else
            {
                pbSkyrimLogo.Refresh();
                pbFog.Refresh();
                pbFog.Visible = false;
            }
            pbSkyrimLogo.Refresh();
            if (!chkFog.Checked && !chkSkyrimLogo.Checked)
            {
                CFormBuilder.notify("Fog removed.", this);
                File.Copy(@"interface\nofog.nif", m_Settings.SkyrimPath + @"\Data\meshes\interface\intmenufogparticles.nif", true);
                bannerinstallmode = menureplacer.nofognologo;
            }
            else if (chkFog.Checked && !chkSkyrimLogo.Checked)
            {
                CFormBuilder.notify("Fog added.", this);
                if (File.Exists(m_Settings.SkyrimPath + @"\Data\meshes\interface\intmenufogparticles.nif"))
                    File.Delete(m_Settings.SkyrimPath + @"\Data\meshes\interface\intmenufogparticles.nif");
                bannerinstallmode = menureplacer.nologo;
            }
            else if (!chkFog.Checked && chkSkyrimLogo.Checked)
            {
                CFormBuilder.notify("Fog removed.", this);
                File.Copy(@"interface\nofog.nif", m_Settings.SkyrimPath + @"\Data\meshes\interface\intmenufogparticles.nif", true);
                bannerinstallmode = menureplacer.nofog;
            }
            else
            {
                CFormBuilder.notify("Fog added.", this);
                if (File.Exists(m_Settings.SkyrimPath + @"\Data\meshes\interface\intmenufogparticles.nif"))
                    File.Delete(m_Settings.SkyrimPath + @"\Data\meshes\interface\intmenufogparticles.nif");
                bannerinstallmode = menureplacer.fogandlogo;
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            PB_Preview.BackgroundImage = null;
            pbSkyrimLogo.Visible = true;
            LBL_Backgroundimage.Text = "";
            if (File.Exists(m_Settings.SkyrimPath + @"\Data\meshes\interface\logo\logo.nif"))
            {
                File.Delete(m_Settings.SkyrimPath + @"\Data\meshes\interface\logo\logo.nif");
            }
            if (File.Exists(m_Settings.SkyrimPath + @"\Data\textures\interface\objects\mainmenuwallpaper.dds"))
                File.Delete(m_Settings.SkyrimPath + @"\Data\textures\interface\objects\mainmenuwallpaper.dds");
            chkSkyrimLogo.Checked = true;
        }

        private void btnRemoveMusic_Click(object sender, EventArgs e)
        {
            if (File.Exists(m_Settings.SkyrimPath + @"\Data\music\special\mus_maintheme.wav"))
                File.Delete(m_Settings.SkyrimPath + @"\Data\music\special\mus_maintheme.wav");
        }

        private void chkSkyrimLogo_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                pbSkyrimLogo.Visible = true;
                pbSkyrimLogo.Refresh();
                pbFog.Refresh();
            }
            else
            {
                pbSkyrimLogo.Visible = false;
                pbSkyrimLogo.Refresh();
                pbFog.Refresh();
            }
            Directory.CreateDirectory(m_Settings.SkyrimPath + @"\Data\meshes\interface\logo\");
            if (!chkFog.Checked && !chkSkyrimLogo.Checked)
            {
                CFormBuilder.notify("Logo removed.", this);
                File.Copy(@"interface\banner.nif", m_Settings.SkyrimPath + @"\Data\meshes\interface\logo\logo.nif", true);
                bannerinstallmode = menureplacer.nofognologo;
            }
            else if (chkFog.Checked && !chkSkyrimLogo.Checked)
            {
                CFormBuilder.notify("Logo removed.", this);
                File.Copy(@"interface\banner.nif", m_Settings.SkyrimPath + @"\Data\meshes\interface\logo\logo.nif", true);
                bannerinstallmode = menureplacer.nologo;
            }
            else if (!chkFog.Checked && chkSkyrimLogo.Checked)
            {
                CFormBuilder.notify("Logo added.", this);
                File.Copy(@"interface\logo.nif", m_Settings.SkyrimPath + @"\Data\meshes\interface\logo\logo.nif", true);
                bannerinstallmode = menureplacer.nofog;
            }
            else
            {
                CFormBuilder.notify("Logo added.", this);
                File.Copy(@"interface\logo.nif", m_Settings.SkyrimPath + @"\Data\meshes\interface\logo\logo.nif", true);
                bannerinstallmode = menureplacer.fogandlogo;
            }
        }

        private void BTN_ImportSTAM_Click(object sender, EventArgs e)
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
                    if (lstAllowedMusicExtensions.FindIndex(x => x.Equals(sExtension, StringComparison.OrdinalIgnoreCase)) != -1)
                    {
                        sOrigTitleMusicPath = ofd.FileName;
                        SetLabelMusic();
                        CFormBuilder.notify("Startup music set.", this);
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
