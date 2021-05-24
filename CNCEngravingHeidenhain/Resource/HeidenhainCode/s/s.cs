using System;
using System.Collections.Generic;
using System.Text;

namespace CNCEngravingHeidenhain.Resource.HeidenhainCode.s
{
    class s
    {
        public static string ModifiCode(int offset)
        {
            string finalCode = String.Format($"L X{0.5+offset} Y1.5 FMAX\n" +
                $"L Z50.0 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"CC X{2.5+offset} Y3.0\n" +
                $"C X{4.167+offset} Y1.137 DR+\n" +
                $"CC X{3.5+offset} Y1.882\n" +
                $"C X{3.947+offset} Y2.776 DR+\n" +
                $"L X{1.053+offset} Y4.224\n" +
                $"CC X{1.5+offset} Y5.118\n" +
                $"C X{0.833+offset} Y5.863 DR-\n" +
                $"CC X{2.5+offset} Y4.0\n" +
                $"C X{4.5+offset} Y5.5 DR-\n" +
                $"L Z2.0\n" +
                $"L Z50.0 FMAX");

            return finalCode;
        }
    }
}
