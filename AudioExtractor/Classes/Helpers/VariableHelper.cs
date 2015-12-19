using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

using AudioExtractor.Structures;

namespace AudioExtractor.Helpers
{
    internal static class VariableHelper
    {
        static VariableHelper()
        {
            _audioDecoders = new Dictionary<String, AudioDecoder>();
        }

        private static readonly String _configFileName = Path.Combine(Application.StartupPath, "AudioExtractor.xml");

        private static AudioOutputDestination _defaultOutputDestination;
        private static String _specifiedOutputFolder;
        private static Boolean _includeSubfolders;
        private static Boolean _deleteSourceFiles;
        private static String _audioDecodersLocation;
        private static Dictionary<String, AudioDecoder> _audioDecoders;

        internal static String ConfigFileName
        {
            get { return _configFileName; }
        }

        internal static AudioOutputDestination DefaultOutputDestination
        {
            get { return _defaultOutputDestination; }
            set { _defaultOutputDestination = value; }
        }

        internal static String SpecifiedOutputFolder
        {
            get { return _specifiedOutputFolder; }
            set { _specifiedOutputFolder = value; }
        }

        internal static Boolean IncludeSubfolders
        {
            get { return _includeSubfolders; }
            set { _includeSubfolders = value; }
        }

        internal static Boolean DeleteSourceFiles
        {
            get { return _deleteSourceFiles; }
            set { _deleteSourceFiles = value; }
        }

        internal static String AudioDecodersLocation
        {
            get { return _audioDecodersLocation; }
            set { _audioDecodersLocation = value; }
        }

        internal static Dictionary<String, AudioDecoder> AudioDecoders
        {
            get { return _audioDecoders; }
        }
    }

    internal enum AudioOutputDestination { SameAsSource, SpecifiedLocation }
}