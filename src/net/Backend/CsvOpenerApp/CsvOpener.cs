using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CsvOpener
{
    public class Opener
    {
        List<string> SchoolClassId = new List<string>();
        List<string> Grade = new List<string>();
        List<string> Section = new List<string>();
        List<string> AcademicYear = new List<string>();
        List<string> Track = new List<string>();
        List<string> StudentCount = new List<string>();
        List<string> GroupCount = new List<string>();
        List<string> IsGraduating = new List<string>();

        public Opener()
        {
            string path = @"C:\VSCodeProjects\VasvariTanarErtekeloRendszer\Angular\gysoft-ver-app-tree-angular-001-bernat\test.csv";

            if (!File.Exists(path))
            {
                throw new FileNotFoundException("The specified CSV file was not found.", path);
            }

            using (var reader = new StreamReader(path, Encoding.UTF8))
            {
                if (reader == null)
                {
                    throw new FileNotFoundException("The specified CSV file was not found.");
                }

                reader.ReadLine(); // Skip header line

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line == null)
                        continue;
                    
                    var values = line.Split(';');
                    if (values.Length >= 8)
                    {
                        SchoolClassId.Add(values[0]);
                        Grade.Add(values[1]);
                        Section.Add(values[2]);
                        AcademicYear.Add(values[3]);
                        Track.Add(values[4]);
                        StudentCount.Add(values[5]);
                        GroupCount.Add(values[6]);
                        IsGraduating.Add(values[7]);
                    }
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < SchoolClassId.Count; i++)
            {
                sb.AppendLine($"SchoolClassId: {SchoolClassId[i]}, Grade: {Grade[i]}, Section: {Section[i]}, AcademicYear: {AcademicYear[i]}, Track: {Track[i]}, StudentCount: {StudentCount[i]}, GroupCount: {GroupCount[i]}, IsGraduating: {IsGraduating[i]}");
            }
            return sb.ToString();
        }
    }
}