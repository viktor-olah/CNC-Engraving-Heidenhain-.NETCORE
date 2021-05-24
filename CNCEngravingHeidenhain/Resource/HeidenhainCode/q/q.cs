using System;
using System.Collections.Generic;
using System.Text;

namespace CNCEngravingHeidenhain.Resource.HeidenhainCode.q
{
    class q
    {
        public static string ModifiCode(int offset)
        {
            string finalCode = String.Format($"L X{4.5+offset} Y-2.5 FMAX\n" +
                $"L Z50.0 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"L Y6.5\n" +
                $"L X{2.0+offset}\n" +
                $"CC X{2.0+offset} Y5.0\n" +
                $"C X{0.5+offset} Y5.0 DR+\n" +
                $"L Y2.0\n" +
                $"CC X{2.0+offset} Y2.0\n" +
                $"C X{2.0+offset} Y0.5 DR+\n" +
                $"L X{4.5+offset} Y0.5\n" +
                $"L Z2.0\n" +
                $"L Z50.0 FMAX");

            return finalCode;
        }
    }
}
