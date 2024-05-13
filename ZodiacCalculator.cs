using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IdolaiCalendarium
{
    public static class ZodiacCalculator
    {
        public static ZodiacSigns GetZodiacSign(int month) => month switch
        {
            1 => ZodiacSigns.TheDragon,
            2 => ZodiacSigns.TheDragon,
            3 => ZodiacSigns.TheWanderer,
            4 => ZodiacSigns.TheWanderer,
            5 => ZodiacSigns.TheLovers,
            6 => ZodiacSigns.TheLovers,
            7 => ZodiacSigns.TheMage,
            8 => ZodiacSigns.TheMage,
            9 => ZodiacSigns.TheMage,
            10 => ZodiacSigns.TheHound,
            11 => ZodiacSigns.TheHound,
            12 => ZodiacSigns.TheSongbird,
            13 => ZodiacSigns.TheSongbird,
            14 => ZodiacSigns.TheEmperor,
            15 => ZodiacSigns.TheEmperor,
            16 => ZodiacSigns.TheDancer,
            17 => ZodiacSigns.TheDancer,
            _ => throw new NotImplementedException(),
        };
        public static ZodiacYear zodiacYear(int year){
            return (ZodiacYear)GetZodiacYear(year);
        }

        static int GetZodiacYear(int year) {
            int i = year % 8;
            return i == 0 ? 8: i; 
        }
    }
}