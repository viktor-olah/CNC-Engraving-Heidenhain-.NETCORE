using System;
using System.Collections.Generic;
using System.Text;

namespace CNCEngravingHeidenhain.Resource.HeidenhainCode._8
{
    class _8
    {
        public static string ModifiCode(int offset)
        {
            string finalCode = String.Format($"L X{2.25+offset} Y5.5 FMAX\n" +
                $"L Z50.0 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"CC X{2.25+offset} Y3.75\n" +
                $"C X{0.5+offset} Y3.75 DR+\n" +
                $"L Y2.5\n" +
                $"CC X{2.5+offset} Y2.5\n" +
                $"C X{4.5+offset} DR+\n" +
                $"L Y3.75\n" +
                $"CC X{2.75+offset} Y3.75\n" +
                $"C X{2.75+offset} Y5.5 DR+\n" +
                $"L X{2.25+offset}\n" +
                $"CC X{2.25+offset} Y7.25\n" +
                $"C X{0.5+offset} Y7.25 DR-\n" +
                $"L X{0.5+offset} Y7.75\n" +
                $"CC X{2.25+offset} Y7.75\n" +
                $"C X{2.25+offset} Y9.5 DR-\n" +
                $"L X{2.75+offset}\n" +
                $"CC X{2.75+offset} Y7.75\n" +
                $"C X{4.5+offset} Y7.75 DR-\n" +
                $"L X{4.5+offset} Y7.25\n" +
                $"CC X{2.75+offset} Y7.25\n" +
                $"C X{2.75+offset} Y5.5 DR-\n" +
                $"L Z2.0\n" +
                $"L Z50.0 FMAX");

            return finalCode;
        }
    }
}
