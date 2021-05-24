using System;
using System.Collections.Generic;
using System.Text;

namespace CNCEngravingHeidenhain.Resource.HeidenhainCode.v
{
    class v
    {
        public static string ModifiCode(int offset)
        {
            string finalCode = String.Format($"L X{0.5+offset} Y6.5 FMAX\n" +
                $"L Z50.0 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"L X{2.5+offset} Y0.5\n" +
                $"L X{4.5+offset} Y6.5\n" +
                $"L Z2.0\n" +
                $"L Z50.0 FMAX");

            return finalCode;
        }
    }
}
