
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
        Program.Log($"Welcome back \"{Environment.UserName}\" to the VER App Cli! Enter a command or type `help` to see valid commands.");
        Program.Log("Type `exit` or `quit` to exit the program.");

        while (true)
        {
            WaitSeconds(2);
            Program.Log("The app is still running");
            Console.Write("> ");
            string command = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(command))
                continue;

            if (command.StartsWith("exit", StringComparison.OrdinalIgnoreCase) ||
                command.StartsWith("quit", StringComparison.OrdinalIgnoreCase))
            {
                Program.Log("Exiting the program...");
                return;
            }

            if (command.StartsWith("help", StringComparison.OrdinalIgnoreCase) ||
                    (command.Equals("ls", StringComparison.OrdinalIgnoreCase)))
            {
                Program.Log($"Valid commands: `{string.Join(", ", ValidCommands.AllCommands)}`");
                continue;
            }

            if (ValidCommands.AllCommands.Any(
                valid => command.StartsWith(valid, StringComparison.OrdinalIgnoreCase)))
            {
                Program.Log("Handling command: " + command);
                try
                {
                    CommandHandler.HandleCommand(command);
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An exception occurred: ", ex, ex.Message);
                }
            }

            Program.Log($"Invalid command: {command}");
        }
    }
}