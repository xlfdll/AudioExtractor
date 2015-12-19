using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

using AudioExtractor.Structures;

namespace AudioExtractor.Helpers
{
    internal static class FormHelper
    {
        internal static void ShowNoDecoderWarning()
        {
            MessageBox.Show(String.Format(@"Audio decoders have not been set yet.{0}""Add File"" and ""Add Folder"" buttons are disabled for now.{0}{0}Please set up audio decoders in Options first.", Environment.NewLine), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            using (ConfigForm configForm = new ConfigForm())
            {
                configForm.ShowDialog();
            }
        }

        internal static String BuildFilterString()
        {
            StringBuilder extensionStringBuilder = new StringBuilder();
            StringBuilder filterStringBuilder = new StringBuilder();

            foreach (KeyValuePair<String, AudioDecoder> pair in VariableHelper.AudioDecoders)
            {
                extensionStringBuilder.AppendFormat("*{0};", pair.Key);

                filterStringBuilder.AppendFormat("{0} (*{1})|*{1}|", pair.Value.Name, pair.Value.Extension);
            }

            extensionStringBuilder.Remove(extensionStringBuilder.Length - 1, 1);

            filterStringBuilder.Insert(0, String.Format("Supported Audio Files ({0})|{0}|", extensionStringBuilder.ToString()));
            filterStringBuilder.Append("All Files (*.*)|*.*");

            return filterStringBuilder.ToString();
        }

        internal static Int32 AddAudioFilesToListView(ListView listView, IEnumerable<String> fileNames)
        {
            Int32 fileNameCount = 0;

            foreach (String fileName in fileNames)
            {
                String fileNameHash = FileHelper.GetFileNameHash(fileName);

                if (!listView.Items.ContainsKey(fileNameHash))
                {
                    String extension = Path.GetExtension(fileName);

                    if (VariableHelper.AudioDecoders.ContainsKey(extension))
                    {
                        String destination = null;

                        switch (VariableHelper.DefaultOutputDestination)
                        {
                            case AudioOutputDestination.SameAsSource:
                                destination = Path.GetDirectoryName(fileName);
                                break;
                            case AudioOutputDestination.SpecifiedLocation:
                                break;
                            default:
                                break;
                        }

                        listView.Items.Add(new ListViewItem(new String[]
                        {
                            Path.GetFileNameWithoutExtension(fileName),
                            extension,
                            VariableHelper.AudioDecoders[extension].Name,
                            Path.GetDirectoryName(fileName),
                            !String.IsNullOrEmpty(destination) ? destination : VariableHelper.SpecifiedOutputFolder
                        }, "Music"));

                        listView.Items[listView.Items.Count - 1].Name = fileNameHash;

                        fileNameCount++;
                    }
                }
            }

            return fileNameCount;
        }

        internal static String GetAudioFileNameFromListViewItem(ListViewItem item)
        {
            return Path.Combine(item.SubItems[3].Text, String.Concat(item.SubItems[0].Text, item.SubItems[1].Text));
        }

        internal static void DecodeSpecifiedItem(ListViewItem item)
        {
            String sourceFileName = Path.Combine(item.SubItems[3].Text, String.Concat(item.SubItems[0].Text, item.SubItems[1].Text));
            String destinationFileName = Path.Combine(item.SubItems[4].Text, String.Concat(item.SubItems[0].Text, ".wav"));

            String executableFileName = Path.Combine(VariableHelper.AudioDecodersLocation, VariableHelper.AudioDecoders[item.SubItems[1].Text].Command);
            String executableArguments = String.Format(VariableHelper.AudioDecoders[item.SubItems[1].Text].Argument, sourceFileName, destinationFileName);

            using (Process process = Process.Start(executableFileName, executableArguments))
            {
                process.WaitForExit();
            }
        }
    }
}