using System;
using System.Collections.Generic;
using System.Text;

namespace CNCEngravingHeidenhain.Resource.HeidenhainCode._6
{
    class _6
    {
        public static string ModifiCode(int offset)
        {
            string finalCode = String.Format($"L X{3.5+offset} Y9.5 FMAX\n" +
                $"L Z50.0 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"CC X{8.424+offset} Y3.285\n" +
                $"C X{0.655+offset} Y1.7 DR+\n" +
                $"CC X{2.125+offset} Y2.0\n" +
                $"C X{2.125+offset} Y0.5 DR+\n" +
                $"L X{3.0+offset}\n" +
                $"CC X{3.0+offset} Y2.0\n" +
                $"C X{4.5+offset} Y2.0 DR +\n" +
                $"L Y4.0\n" +
                $"CC X{3.0+offset} Y4.0\n" +
                $"C X{3.0+offset} Y5.5 DR+\n" +
                $"L X{0.811+offset}\n" +
                $"L Z2.0\n" +
                $"L Z50.0 FMAX M");

            return finalCode;
        }
    }
}
