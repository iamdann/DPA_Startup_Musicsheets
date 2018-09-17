using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPA_Musicsheets.Models.FileReader
{
    class FileReaderFactory
    {
        Dictionary<string, IFileReader> options = new Dictionary<string, IFileReader>();

        public FileReaderFactory()
        {
            options.Add(".mid", new MidiFileReader());
            options.Add(".ly", new LilypondFileReader());
        }

        public IFileReader GetFactory(string fileName)
        {
            string fileExtention = Path.GetExtension(fileName);

            if (options[fileExtention] == null) throw new Exception($"File extension {Path.GetExtension(fileName)} is not supported.");
            return options[fileExtention];
        }
    }
}
