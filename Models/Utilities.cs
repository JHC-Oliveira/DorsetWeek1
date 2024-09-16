using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeros.Models
{
    public static class Utilities
    {
        public static string GetDayOfWeek(int day)
        {
            string WeekDay = string.Empty;
            switch (day)
            {
                case 1:
                    WeekDay = "Monday";
                    break;
                case 2:
                    WeekDay = "Tuesday";
                    break;
                case 3:
                    WeekDay = "Wednesday";
                    break;
                case 4:
                    WeekDay = "Thursday";
                    break;
                case 5:
                    WeekDay = "Friday";
                    break;
                case 6:
                    WeekDay = "Saturday";
                    break;
                case 7:
                    WeekDay = "Sunday";
                    break;
            }
            
            return WeekDay;
        }
    }
}
