using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowMuchTimePassed
{
    static class MonthDifferencer
    {
        public static int MonthDifference(this DateTime currentDate, DateTime birthday)
        {
            return (currentDate.Month - birthday.Month) + 12 * (currentDate.Year - birthday.Year);
        }
    }
}
