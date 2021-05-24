using System;
using System.Collections.Generic;
using System.Text;

namespace CNCEngravingHeidenhain.Resource.HeidenhainCode.f
{
    class f
    {
        public static string ModifiCode(int offset)
        {
            string finalCode = String.Format($"L X{2.0+offset} Y0.5 FMAX\n" +
                $"L Z50.0 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"L X{2.0+offset} Y7.5\n" +
                $"CC X{4.0+offset} Y7.5\n" +
                $"C X{4.0+offset} Y9.5 DR-\n" +
                $"L Z2.0\n" +
                $"L Z50.0 FMAX\n" +
                $"L X{0.5+offset} Y6.5 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"L X{4.0+offset}\n" +
                $"L Z2.0\n" +
                $"L Z50.0 FMAX");

            return finalCode;
        }
    }
}
