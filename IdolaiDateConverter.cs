using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace IdolaiCalendarium
{
    public class IdolaiDateConverter
    {
        int jahrNull;
        public IdolaiDateConverter(int jahrNull = -2150) {
            this.jahrNull = jahrNull;
        }

        public IdolaiDate ConvertAddDay(DateTime earthDate){
            int offset = (int) Math.Round((-jahrNull - (jahrNull < 0 ? 1 : 0)) * 365.25f);
            int earthDays = earthDate.Subtract(DateTime.MinValue).Days + offset;
            IdolaiDate idolaiDate = new();
            return idolaiDate.AddDays(earthDays);
        }

        public IdolaiDate Convert(DateTime earthDate) {
            int offset = (int) Math.Round((-jahrNull - (jahrNull < 0 ? 1 : 0)) * 365.25f);
            int earthDays = earthDate.Subtract(DateTime.MinValue).Days + offset;
            return Convert(earthDays);
        }

        public static IdolaiDate Convert(int Days) {
            int auxDays = Days + 1;
            int year = 1;
            while (auxDays > IdolaiCalendar.DaysInYear(year))
            {
                auxDays -= IdolaiCalendar.DaysInYear(year);
                year++;
            }

            int month = 1;
            while (auxDays > IdolaiCalendar.DaysPerMonth)
            {
                auxDays -= IdolaiCalendar.DaysPerMonth;
                month ++;
            }
            int days = auxDays;
            return new IdolaiDate(year, month, days);
        }

    }
}