using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GardenPlots
{
    class FileWriter
    {
        
        string _fileName;
        public FileWriter(string FileName)
        {
            this._fileName = FileName;
        }
        public void WriteListToFile(List<Plot> plots)
        {
            using (FileStream fs = new FileStream(_fileName, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (Plot plot in plots)
                    {
                        sw.WriteLine(plot);
                    }
                }
            }
        }
        public void WriteToFile(object obj)
        {
            using (FileStream fs = new FileStream(_fileName, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(obj);
                }
            }
        }
    }
}


