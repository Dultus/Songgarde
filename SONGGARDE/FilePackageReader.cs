using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Drawing;

namespace SONGGARDE
{
    public class FilePackageReader
    {
        private Dictionary<string, Image> _filenamePictureContentDictionary;
        private Dictionary<string, string> _filenameFileContentDictionary;
        private readonly string _filepath;

        public FilePackageReader(string filepath)
        {
            _filepath = filepath;
        }

        public Dictionary<string, Image> GetPictureNamePictureContentDictionary()
        {
            try
            {
                _filenamePictureContentDictionary = new Dictionary<string, Image>();

                // Open the package file
                using (var fs = new FileStream(_filepath, FileMode.Open))
                {
                    // Open the package file as a ZIP
                    using (var archive = new ZipArchive(fs))
                    {
                        // Iterate through the content files and add them to a dictionary
                        foreach (var zipArchiveEntry in archive.Entries)
                        {
                            using (var stream = zipArchiveEntry.Open())
                            {
                                try
                                {
                                    _filenamePictureContentDictionary.Add(zipArchiveEntry.Name, Image.FromStream(stream));
                                }
                                catch
                                { }
                            }
                        }
                    }
                }

                return _filenamePictureContentDictionary;
            }
            catch (Exception e)
            {
                var errorMessage = "Unable to open/read the package. " + e.Message;
                throw new Exception(errorMessage);
            }
        }
        public Dictionary<string, string> GetFileNameFileContentDictionary()
        {
            try
            {
                _filenameFileContentDictionary = new Dictionary<string, string>();

                // Open the package file
                using (var fs = new FileStream(_filepath, FileMode.Open))
                {
                    // Open the package file as a ZIP
                    using (var archive = new ZipArchive(fs))
                    {
                        // Iterate through the content files and add them to a dictionary
                        foreach (var zipArchiveEntry in archive.Entries)
                        {
                            using (var stream = zipArchiveEntry.Open())
                            {
                                using (var zipSr = new StreamReader(stream))
                                {
                                    try
                                    {
                                        _filenameFileContentDictionary.Add(zipArchiveEntry.Name, zipSr.ReadToEnd());
                                    }
                                    catch
                                    { }
                                }
                            }
                        }
                    }
                }

                return _filenameFileContentDictionary;
            }
            catch (Exception e)
            {
                var errorMessage = "Unable to open/read the package. " + e.Message;
                throw new Exception(errorMessage);
            }
        }
    }
}
