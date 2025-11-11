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
                HandleSeasonAction(
                   "Are you sure you want to start a new evaluation season? (y/n)",
                   SeasonActionManager.StartSeason,
                   "New evaluation season successfully started",
                   "Evaluation season is already active. Cannot start a new one."
               );
            }




            else if (command.StartsWith("terminate", StringComparison.OrdinalIgnoreCase))
            {
                HandleSeasonAction(
                     "Are you sure you want to terminate the current evaluation season? (y/n)",
                     SeasonActionManager.TerminateSeason,
                     "Evaluation season successfully terminated",
                     "No active evaluation season found. Cannot terminate."
                 );
            }



            Program.Log("Executed command: " + command);
        }

        private static void HandleSeasonAction(
            string confirmationMessage,
            Func<bool> action,
            string successMessage,
            string failureMessage)
        {
            Program.Log(confirmationMessage);
            string? input = System.Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Program.Log("Please press 'y' or 'n'.");
                return;
            }

            input = input.Trim().ToLowerInvariant();

            if (input == "y")
            {
                if (action())
                    Program.Log(successMessage);
                else
                    Program.Log(failureMessage);
            }
            else if (input == "n")
                Program.Log("Aborting operation.");
            else
                Program.Log("Please press 'y' or 'n'.");
        }
    }
}
