using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenPlots
{
    class Program
    {
        static void Main(string[] args)
        {
            Command test = new Command();
            test.ExecuteCommand();

            //List<Plot> testplots = new List<Plot>();
            //FileReader tr = new FileReader(@"../../test.txt");
            //testplots = tr.ReadFromFile();

            //FileWriter tw = new FileWriter(@"../../newfiletest.txt");
            //tw.WriteToFile(testplots);

        }
    }
}
