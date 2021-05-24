using System;
using System.Collections.Generic;
using System.Text;

namespace CNCEngravingHeidenhain.Resource.HeidenhainCode.b
{
    class c
    {
        public static string ModifiCode(int offset)
        {
            string finalCode = String.Format($"L X{0.5+offset} Y9.5 FMAX\n" +
                $"L Z50.0 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"L X{0.5+offset} Y0.5\n" +
                $"L X{3.0+offset} Y0.5\n" +
                $"CC X{3.0+offset} Y2.0\n" +
                $"C X{4.5+offset} Y2.0 DR+\n" +
                $"L Y5.0\n" +
                $"CC X{3.0+offset} Y5.0\n" +
                $"C X{3.0+offset} Y6.5 DR+\n" +
                $"L X{0.5+offset}\n" +
                $"L Z2.0\n" +
                $"L Z50.0 FMAX");

            return finalCode;
        }
    }
}
