using ConsoleApp;
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
            if (command == "teachers" || command == "results" || command == "students")
                Reader.ReadCsv(command);




            else if (command.StartsWith("create", StringComparison.OrdinalIgnoreCase))
            {
                Program.Log("Are you sure you want to start a new evaluation season? (y/n)");
                string? input = System.Console.ReadLine();

                if (!string.IsNullOrEmpty(input) && input.Trim().Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    if (SeasonActionManager.StartSeason())
                        Program.Log("New evaluation season successfully started");
                    else
                        Program.Log("Evaluation season is already active. Cannot start a new one.");
                }
                else if (input.Trim().Equals("n", StringComparison.OrdinalIgnoreCase))
                    Program.Log("Aborting operation.");
                else
                    Program.Log("Please press 'y' or 'n'.");
            }







            else if (command.StartsWith("terminate", StringComparison.OrdinalIgnoreCase))
            {
                Program.Log("Are you sure you want to terminate the current  evaluation season? (y/n)");
                
                if ()
                {
                    if (SeasonActionManager.TerminateSeason())
                        Program.Log("Evaluation season successfully terminated");
                    else
                        Program.Log("No active evaluation season found. Cannot terminate.");
                }
                else if ()
                    Program.Log("Aborting operation.");
                else
                    Program.Log("Please press 'y' or 'n'.");

            }



            Program.Log("Executed command: " + command);
        }
    }
}
