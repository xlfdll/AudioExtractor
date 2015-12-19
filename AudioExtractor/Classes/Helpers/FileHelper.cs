using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography;
using System.IO;

namespace AudioExtractor.Helpers
{
    internal static class FileHelper
    {
        internal static ReadOnlyCollection<String> GetAudioFilesFromFolder(String folderName)
        {
            List<String> audioFileList = new List<String>();

            foreach (String extension in VariableHelper.AudioDecoders.Keys)
            {
                audioFileList.AddRange(Directory.GetFiles(folderName, String.Concat("*", extension), SearchOption.TopDirectoryOnly));
            }

            if (VariableHelper.IncludeSubfolders)
            {
                foreach (String subFolderName in Directory.GetDirectories(folderName))
                {
                    try
                    {
                        audioFileList.AddRange(GetAudioFilesFromFolder(subFolderName));
                    }
                    catch (UnauthorizedAccessException) { }
                }
            }

            return audioFileList.AsReadOnly();
        }

        internal static String GetFileNameHash(String fileName)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Byte b in hashProvider.ComputeHash(Encoding.UTF8.GetBytes(fileName)))
            {
                sb.Append(b.ToString("X2"));
            }

            return sb.ToString();
        }

        private static readonly HashAlgorithm hashProvider = SHA1.Create();
    }
}