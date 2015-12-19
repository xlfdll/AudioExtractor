using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using System.IO;

using AudioExtractor.Structures;

namespace AudioExtractor.Helpers
{
    internal static class ConfigHelper
    {
        internal static void CreateConfiguration(String fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                using (StreamReader reader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("AudioExtractor.AudioExtractor.xml")))
                {
                    writer.Write(reader.ReadToEnd());
                }
            }
        }

        internal static void LoadConfiguration(String fileName)
        {
            XmlNodeList xmlNodeList;

            configXmlDocument.Load(fileName);

            xmlNodeList = configXmlDocument.GetElementsByTagName("Settings");

            VariableHelper.DefaultOutputDestination = (AudioOutputDestination)Enum.Parse(typeof(AudioOutputDestination), xmlNodeList[0].ChildNodes[0].InnerText);
            VariableHelper.SpecifiedOutputFolder = xmlNodeList[0].ChildNodes[1].InnerText;
            VariableHelper.IncludeSubfolders = Convert.ToBoolean(xmlNodeList[0].ChildNodes[2].InnerText);
            VariableHelper.DeleteSourceFiles = Convert.ToBoolean(xmlNodeList[0].ChildNodes[3].InnerText);

            xmlNodeList = configXmlDocument.GetElementsByTagName("Decoders");

            VariableHelper.AudioDecodersLocation = xmlNodeList[0].Attributes["Location"].Value;

            foreach (XmlNode node in xmlNodeList[0].ChildNodes)
            {
                VariableHelper.AudioDecoders.Add(node.Attributes["Extension"].Value, new AudioDecoder(node.Attributes["Name"].Value, node.Attributes["Extension"].Value, node.Attributes["Command"].Value, node.Attributes["Argument"].Value));
            }
        }

        internal static void SaveConfiguration(String fileName)
        {
            XmlNodeList xmlNodeList;

            xmlNodeList = configXmlDocument.GetElementsByTagName("Settings");

            xmlNodeList[0].ChildNodes[0].InnerText = VariableHelper.DefaultOutputDestination.ToString();
            xmlNodeList[0].ChildNodes[1].InnerText = VariableHelper.SpecifiedOutputFolder;
            xmlNodeList[0].ChildNodes[2].InnerText = VariableHelper.IncludeSubfolders.ToString();
            xmlNodeList[0].ChildNodes[3].InnerText = VariableHelper.DeleteSourceFiles.ToString();

            xmlNodeList = configXmlDocument.GetElementsByTagName("Decoders");

            xmlNodeList[0].Attributes["Location"].Value = VariableHelper.AudioDecodersLocation;

            while (xmlNodeList[0].ChildNodes.Count > 0)
            {
                xmlNodeList[0].RemoveChild(xmlNodeList[0].ChildNodes[xmlNodeList[0].ChildNodes.Count - 1]);
            }

            foreach (KeyValuePair<String, AudioDecoder> pair in VariableHelper.AudioDecoders)
            {
                XmlNode formatNode = xmlNodeList[0].AppendChild(configXmlDocument.CreateElement("Format"));

                formatNode.Attributes.Append(configXmlDocument.CreateAttribute("Name")).Value = pair.Value.Name;
                formatNode.Attributes.Append(configXmlDocument.CreateAttribute("Extension")).Value = pair.Value.Extension;
                formatNode.Attributes.Append(configXmlDocument.CreateAttribute("Command")).Value = pair.Value.Command;
                formatNode.Attributes.Append(configXmlDocument.CreateAttribute("Argument")).Value = pair.Value.Argument;
            }

            configXmlDocument.Save(fileName);
        }

        private static readonly XmlDocument configXmlDocument = new XmlDocument();
    }
}