using System;
using System.Collections.Generic;
using System.Text;

namespace CNCEngravingHeidenhain.Resource.HeidenhainCode._0
{
    class _0
    {
        public static string ModifiCode(int offset)
        {
            string finalCode = String.Format($"L X{1.376+offset} Y1.202 FMAX\n" +
                $"L Z50.0 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"CC X{2.5+offset} Y1.75\n" +
                $"C X{3.624+offset} DR+\n" +
                $"CC X{-4.167+offset} Y5.0\n" +
                $"C Y8.798 DR+\n" +
                $"CC X{2.5+offset} Y8.25\n" +
                $"C X{1.376+offset} DR+\n" +
                $"CC X{9.167+offset} Y5.0\n" +
                $"C Y1.202 DR+\n" +
                $"L Z2.0\n" +
                $"L Z50.0 FMAX");

            return finalCode;
        }
    }
}
