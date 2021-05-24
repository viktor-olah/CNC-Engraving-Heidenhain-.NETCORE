using System;
using System.Collections.Generic;
using System.Text;

namespace CNCEngravingHeidenhain.Resource.HeidenhainCode.j
{
    class j
    {
        public static string ModifiCode(int offset)
        {
            string finalCode = String.Format($"L X{-1.5+offset} Y-2.5 FMAX\n" +
                $"L Z50.0 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"L X{-1.0+offset}\n" +
                $"CC X{-1.0+offset} Y-1.0\n" +
                $"C X{0.5+offset} Y-1.0 DR+\n" +
                $"L Y6.5\n" +
                $"L Z2.0\n" +
                $"L Z50.0 FMAX\n" +
                $"L Y9.5 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"L Z2.0\n" +
                $"L Z50.0 FMAX");

            return finalCode;
        }
    }
}
