using System;
using System.Collections.Generic;
using System.Text;

namespace CNCEngravingHeidenhain.Resource.HeidenhainCode.e
{
    class e
    {
        public static string ModifiCode(int offset)
        {
            string finalCode = String.Format($"L X{0.5+offset} Y3.5 FMAX\n" +
                $"L Z50.0 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"L X{4.5+offset}\n" +
                $"L X{4.5+offset} Y4.5\n" +
                $"CC X{2.5+offset} Y4.5\n" +
                $"C X{0.5+offset} DR+\n" +
                $"L X{0.5+offset} Y2.0\n" +
                $"CC X{2.0+offset} Y2.0\n" +
                $"C X{2.0+offset} Y0.5 DR+\n" +
                $"L X{4.5+offset} Y0.5\n" +
                $"L Z2.0\n" +
                $"L Z50.0 FMAX");

            return finalCode;
        }
    }
}
