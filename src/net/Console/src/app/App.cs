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
        while (true)
        {
            WaitSeconds(2);
            Program.Log("The app is still running");
        }
    }
}