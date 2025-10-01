using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Console.Repos
{
    internal class TeacherRepo
    {
        int _count;

        public TeacherRepo(int count)
        {
            _count = count;
        }

        public int Count { get { return _count; } }

        public override string ToString()
        {
            return $"Tanárok száma: {_count}";
        }
    }
}
