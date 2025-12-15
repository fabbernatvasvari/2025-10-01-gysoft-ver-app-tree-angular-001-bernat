
using MyApp.Console.src.utils;

namespace ConsoleApp;

internal class App
{

    public void WaitSeconds(double seconds)
    {
        Thread.Sleep((int)(seconds * 1000));
    }

    internal void Start()
    {
        Program.Log(I18n.T("Welcome", Environment.UserName));
        Program.Log(I18n.T("ExitHint"));

        while (true)
        {
            // WaitSeconds(2);
            // Program.Log("The app is still running");
            Console.Write("> ");
            string command = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(command))
                continue;

            if (command.StartsWith("exit", StringComparison.OrdinalIgnoreCase) ||
                command.StartsWith("quit", StringComparison.OrdinalIgnoreCase))
            {
                Program.Log(I18n.T("Exiting"));
                return;
            }

            if (command.StartsWith("help", StringComparison.OrdinalIgnoreCase) ||
                    (command.Equals("ls", StringComparison.OrdinalIgnoreCase)))
            {
                Program.Log(I18n.T("ValidCommands") + string.Join(", ", ValidCommands.AllCommands));
                continue;
            }

            if (ValidCommands.AllCommands.Any(
                valid => command.StartsWith(valid, StringComparison.OrdinalIgnoreCase)))
            {
                Program.Log(I18n.T("HandlingCommand") + command);
                try
                {
                    while (!CommandHandler.HandleCommand(command))
                    {

                    }
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(I18n.T("ExceptionOccurred"), ex, ex.Message);
                }
            }

            Program.Log(I18n.T("InvalidCommand"));
        }
    }
}