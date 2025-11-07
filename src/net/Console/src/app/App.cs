
namespace ConsoleApp;

internal class App
{

    public void WaitSeconds(double seconds)
    {
        Thread.Sleep((int)(seconds * 1000));
    }

    internal void Start()
    {
        Program.Log($"Welcome back \"{Environment.UserName}\" to the VER App Cli! Type `help` to see valid commands");
        Program.Log("type 'exit' / 'quit' to stop");

        while (true)
        {
            WaitSeconds(2);
            Program.Log("The app is still running");
            Console.Write("> ");
            string input = Console.ReadLine()?.Trim();

            if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(input, "quit", StringComparison.OrdinalIgnoreCase))
            {
                Program.Log("Exiting the program...");
                break;
            }

            Program.Log($"You entered: {input}");
        }
    }
}