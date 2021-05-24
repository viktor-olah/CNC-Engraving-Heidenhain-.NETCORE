using System;
using System.Collections.Generic;
using System.Text;

namespace CNCEngravingHeidenhain.Resource.HeidenhainCode._9
{
    class _9
    {
        public static string ModifiCode(int offset)
        {
            string finalCode = String.Format($"L X{1.5+offset} Y0.5 FMAX\n" +
                $"L Z50.0 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"CC X{-3.424+offset} Y6.715\n" +
                $"C X{4.353+offset} Y8.263 DR+\n" +
                $"CC X{2.503+offset} Y7.497\n" +
                $"C X{0.5+offset} Y7.497 DR+\n" +
                $"L Y6.5\n" +
                $"CC X{2.5+offset} Y6.5\n" +
                $"C X{2.5+offset} Y4.5 DR+\n" +
                $"L X{4.189+offset}\n" +
                $"L Z2.0\n" +
                $"L Z50.0 FMAX");

            return finalCode;
        }
    }
}
