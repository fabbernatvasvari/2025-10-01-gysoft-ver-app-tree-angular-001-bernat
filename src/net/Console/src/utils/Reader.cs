
namespace MyApp.Console.src.utils
{
    internal class Reader
    {

        // Returns the whole file as a single string
        internal static string ReadCsvAsString(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"The file at {path} was not found.");

            return File.ReadAllText(path);
        }

        // Returns the file as a list (array) of lines
        internal static string[] ReadCsvAsList(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"The file at {path} was not found.");

            return File.ReadAllLines(path);
        }
    }
}