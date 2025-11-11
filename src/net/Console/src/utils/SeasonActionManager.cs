using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Console.src.utils
{
    internal class SeasonActionManager
    {
        private static string status;
        public static bool StartSeason()
        {
            if (status != "active")
            {
                status = "active";
                return true;
            }
            return false;
        }

        public static bool TerminateSeason()
        {
            if (status != "inactive")
            {
                status = "inactive";
                return true;
            }
            return false;
        }
    }
}
