namespace ConsoleApp;

internal class Program
{
    public static void Log(string? message)
    {
        Console.WriteLine(message);
    }

    private static void Main(string[] args)
    {
        App app = new App();
        app.Start();
    }
}