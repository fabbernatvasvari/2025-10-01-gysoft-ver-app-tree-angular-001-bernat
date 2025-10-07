using System;
namespace CsvOpener
{
    public class Opener
    {
        List<string> SchoolClassId = new List<string>();
        List<int> Grade = new List<int>();
        List<string> Section = new List<string>();
        List<string> AcademicYear = new List<string>();
        List<string> Track = new List<string>();
        List<int> StudentCount = new List<int>();
        List<int> GroupCount = new List<int>();
        List<bool> IsGraduating = new List<bool>();

        public Opener()
        {
            using (var reader = new StreamReader(@"C:\VSCodeProjects\VasvariTanarErtekeloRendszer\Angular\gysoft-ver-app-tree-angular-001-bernat\test.csv"))
            {
                if (reader == null)
                {
                    throw new FileNotFoundException("The specified CSV file was not found.");
                }
                while (!reader.EndOfStream)
                {
                    reader.ReadLine(); // Skip header line

                    var line = reader.ReadLine();
                    if (line == null)
                    {
                        continue; // Skip if the line is null
                    }
                    var values = line.Split(';');
                    if (values.Length >= 8)
                    {
                        SchoolClassId.Add(values[0]);
                        Grade.Add(int.Parse(values[1]));
                        Section.Add(values[2]);
                        AcademicYear.Add(values[3]);
                        Track.Add(values[4]);
                        StudentCount.Add(int.Parse(values[5]));
                        GroupCount.Add(int.Parse(values[6]));
                        IsGraduating.Add(bool.Parse(values[7]));
                    }
                }
            }
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < SchoolClassId.Count; i++)
            {
                result += $"{SchoolClassId[i]}, {Grade[i]}, {Section[i]}, {AcademicYear[i]}, {Track[i]}, {StudentCount[i]}, {GroupCount[i]}, {IsGraduating[i]}\n";
            }
            return result;
        }
    }
}