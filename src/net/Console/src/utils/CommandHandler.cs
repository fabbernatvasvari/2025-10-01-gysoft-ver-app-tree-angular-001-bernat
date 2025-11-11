using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Console.src.utils
{
    internal class CommandHandler
    {
        internal static void HandleCommand(string command)
        {
            if (command == "teachers" || command == "results")
            {
                Reader.ReadCsv("teachers.csv");
            }
            System.Console.WriteLine("Executed command: " + command); 
        }
    }
}
