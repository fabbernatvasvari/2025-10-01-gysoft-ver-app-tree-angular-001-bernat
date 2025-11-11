using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Console.src.utils
{
    internal class ValidCommands
    {
        public static readonly HashSet<string> ISOValidCommands =
            new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "results",
                "teachers",
                "students",
                "create",
                "terminate"
            };
    }
}
