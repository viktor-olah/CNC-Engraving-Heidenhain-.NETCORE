using System;
using System.Collections.Generic;
using System.Text;

namespace CNCEngravingHeidenhain.Resource.HeidenhainCode.m
{
    class m
    {
        public static string ModifiCode(int offset)
        {
            string finalCode = String.Format($"L X{0.5+offset} Y0.5 FMAX\n" +
                $"L Z50.0 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"L X{0.5+offset} Y6.5\n" +
                $"L X{3.5+offset}\n" +
                $"L Y0.5\n" +
                $"L Z2.0\n" +
                $"L Z50.0 FMAX\n" +
                $"L Y6.5 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"L X{5.0+offset}\n" +
                $"CC X{5.0+offset} Y5.0\n" +
                $"C X{6.5+offset} Y5.0 DR-\n" +
                $"L Y0.5\n" +
                $"L Z2.0\n" +
                $"L Z50.0 FMAX");

            return finalCode;
        }
    }
}
