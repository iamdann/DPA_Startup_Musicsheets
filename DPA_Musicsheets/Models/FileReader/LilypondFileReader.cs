using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPA_Musicsheets.Models.FileReader
{
    class LilypondFileReader : IFileReader
    {
        public string Load(string fileName)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var line in File.ReadAllLines(fileName))
            {
                sb.AppendLine(line);
            }

            return sb.ToString();
        }
    }
}
