using System;
using System.IO;

namespace SquishIt.Framework.Files
{
    public class FileReader: IFileReader
    {
        private StreamReader streamReader;
        
        public FileReader(string file)
        {
            streamReader = new StreamReader(file, System.Text.Encoding.UTF8);
        }

        public string ReadLine()
        {
            return streamReader.ReadLine();
        }

        public string ReadToEnd()
        {
            return streamReader.ReadToEnd();
        }

        public void Dispose()
        {
            if (streamReader != null)
            {
                streamReader.Dispose();
            }
        }
    }
}