using MyApp.Console.src.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Console.src.repo
{
    internal class Teachers
    {
        public static List<string> AllTeachers = new List<Teacher>().Select(t => t.ToString()).ToList();
    }
}
