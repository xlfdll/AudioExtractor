using System;

namespace AudioExtractor.Structures
{
    internal class AudioDecoder
    {
        private AudioDecoder() { }

        internal AudioDecoder(String name, String extension, String command, String argument)
        {
            _name = name;
            _extension = extension;
            _command = command;
            _argument = argument;
        }

        private String _name;
        private String _extension;
        private String _command;
        private String _argument;

        internal String Name
        {
            get { return _name; }
        }

        internal String Extension
        {
            get { return _extension; }
        }

        internal String Command
        {
            get { return _command; }
        }

        internal String Argument
        {
            get { return _argument; }
        }
    }
}