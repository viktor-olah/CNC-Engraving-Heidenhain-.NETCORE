using System;
using System.Collections.Generic;
using System.Text;

namespace CNCEngravingHeidenhain.Resource.HeidenhainCode.l
{
    class l
    {
        public static string ModifiCode(int offset)
        {
            string finalCode = String.Format($"L X{2.0+offset} Y0.5 FMAX\n" +
                $"L Z50.0 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"CC X{2.0+offset} Y2.0\n" +
                $"C X{0.5+offset} Y2.0 DR-\n" +
                $"L X{0.5+offset} Y9.5\n" +
                $"L Z2.0\n" +
                $"L Z50.0 FMAX");

            return finalCode;
        }
    }
}
