using System;
using System.Collections.Generic;
using System.Text;

namespace CNCEngravingHeidenhain.Resource.HeidenhainCode._2
{
    class _2
    {
        public static string ModifiCode(int offset)
        {
            string finalCode = String.Format($"L X{0.802+offset} Y8.557 FMAX\n" +
                $"L Z50.0 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"CC X{2.5+offset} Y7.5\n" +
                $"C X{4.198+offset} Y6.443 DR-\n" +
                $"L X{0.5+offset} Y0.5\n" +
                $"L X{4.5+offset} Y0.5\n" +
                $"L Z2.0\n" +
                $"L Z50.0 FMAX");

            return finalCode;
        }
    }
}
