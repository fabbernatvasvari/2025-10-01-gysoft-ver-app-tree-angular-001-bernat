

using ConsoleApp;

namespace MyApp.Console.src.utils
{
    internal class Reader
    {
        static string teachersCsvPath = @"D:\MixedProjects\251107-gysoft-ver-app-bernat-egyeni\adatbazis\tesztadatok\tanarok.csv";
        static string testDataCsvPath = @"D:\MixedProjects\251107-gysoft-ver-app-bernat-egyeni\adatbazis\tesztadatok\tesztadatok.csv";
        internal static void ReadCsv(string command)
        {
            string csvContent = string.Empty;
            string[] csvLines = Array.Empty<string>();

            if ("teachers".Equals(command, StringComparison.OrdinalIgnoreCase))
            {
                csvContent = Reader.ReadCsvAsString(Reader.teachersCsvPath);
                csvLines = Reader.ReadCsvAsList(Reader.teachersCsvPath);
            } else if ("results".Equals(command, StringComparison.OrdinalIgnoreCase))
            {
                csvContent = Reader.ReadCsvAsString(Reader.testDataCsvPath);
                csvLines = Reader.ReadCsvAsList(Reader.testDataCsvPath);
            }

            Program.Log(csvContent);

            
            foreach (var line in csvLines)
            {
                Program.Log(line);
            }
        }

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