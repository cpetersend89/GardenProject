using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenPlots
{
    class Command
    {
        private UserInput _userInput;
        public Command()
        {
            _userInput = new UserInput();
            _userInput.GetUserInput();
        }
        public void ExecuteCommand()
        {
            switch(_userInput.UserInputArray[0])
            {
                case "1":
                    break;
                case "2":
                    List<Plot> plots;
                    FileReader fr = new FileReader(_userInput.UserInputArray[1]);
                    plots = fr.ReadFromFile();

                    int totalfencing;
                    Garden fencing = new Garden(plots);
                    totalfencing = fencing.GetFencing();
                    FileWriter fw = new FileWriter(_userInput.UserInputArray[2]);
                    fw.WriteToFile(totalfencing);
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                default:
                    break;
            }
        }

    }
}
