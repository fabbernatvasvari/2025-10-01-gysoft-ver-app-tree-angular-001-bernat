using System;

public class CsvOpener
{
    public static void Main(string[] args)
    {
        using (var reader = new StreamReader(@"C:\VSCodeProjects\VasvariTanarErtekeloRendszer\Angular\gysoft-ver-app-tree-angular-001-bernat\test.csv"))
        {
            List<string> listA = new List<string>();
            List<string> listB = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                listA.Add(values[0]);
                listB.Add(values[1]);
            }
        }
    }
}

