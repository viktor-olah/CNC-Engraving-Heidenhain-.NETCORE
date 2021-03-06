using System;
using System.Collections.Generic;
using System.Text;

namespace CNCEngravingHeidenhain.Resource.HeidenhainCode._4
{
    class _4
    {
        public static string ModifiCode(int offset)
        {
            string finalCode = String.Format($"L X{2.5+offset} Y9.5 FMAX\n" +
                $"L Z50.0 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"L X{0.5+offset} Y2.5\n" +
                $"L X{6.0+offset}\n" +
                $"L Z2.0\n" +
                $"L Z50.0 FMAX\n" +
                $"L X{3.0+offset} Y4.5 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"L Y0.5\n" +
                $"L Z2.0\n" +
                $"L Z50.0 FMAX");

            return finalCode;
        }
    }
}
