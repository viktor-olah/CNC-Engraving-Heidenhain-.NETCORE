using System;
using System.Collections.Generic;
using System.Text;

namespace CNCEngravingHeidenhain.Resource.HeidenhainCode.i
{
    class i
    {
        public static string ModifiCode(int offset)
        {
            string finalCode = String.Format($"L X{0.5+offset} Y0.5 FMAX\n" +
                $"L Z50.0 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"L X{0.5+offset} Y6.5\n" +
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
