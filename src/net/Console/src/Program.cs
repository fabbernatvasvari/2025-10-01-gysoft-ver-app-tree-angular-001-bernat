namespace ConsoleApp;

using System.Globalization;

internal class Program
{
    public static void Log(string? message)
    {
        Console.WriteLine(message);
    }

    private static void Main(string[] args)
    {
        // nyelv beállítása magyarra
        CultureInfo.CurrentUICulture = new CultureInfo("hu-HU");
        CultureInfo.CurrentCulture = new CultureInfo("hu-HU");

        App app = new App();
        app.Start();
    }
}