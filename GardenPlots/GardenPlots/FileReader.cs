using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenPlots
{
    class FileReader
    {
        private string _filename;
        public FileReader(string FileName)
        {
            _filename = FileName;
        }
        public List<Plot> ReadFromFile()
        {
            using (FileStream filestream = new FileStream(_filename, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader streamreader = new StreamReader(filestream))
                {
                    List<Plot> plots = new List<Plot>();
                    while (!streamreader.EndOfStream)
                    {
                        string storestring = streamreader.ReadLine();
                        string[] parseString = storestring.Split(',');
                        plots.Add(new Plot(int.Parse(parseString[0]), int.Parse(parseString[1]), int.Parse(parseString[2]), int.Parse(parseString[3])));
                    }
                    return plots;
                }
                
            }
        }
    }
}




