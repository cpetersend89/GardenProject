using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenPlots
{
    class UserInput
    {
        public string[] UserInputArray { get; set; }
        public UserInput()
        {

        }
        public void GetUserInput()
        {
            string getUserInput = Console.ReadLine();
            UserInputArray = getUserInput.Split(' ');
        }
    }
}
