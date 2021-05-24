﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CNCEngravingHeidenhain.Resource.HeidenhainCode._3
{
    class _3
    {
        public static string ModifiCode(int offset)
        {
            string finalCode = String.Format($"L X{0.5+offset} Y0.5 FMAX\n" +
                $"L Z50.0 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"L X{2.5+offset} Y0.5\n" +
                $"CC X{2.5+offset} Y2.5\n" +
                $"C X{4.5+offset} Y2.5 DR+\n" +
                $"L X{4.5+offset} Y3.5\n" +
                $"CC X{2.5+offset} Y3.5\n" +
                $"C X{2.5+offset} Y5.5 DR+\n" +
                $"CC X{2.5+offset} Y7.5\n" +
                $"C Y9.5 DR+\n" +
                $"L X{0.5+offset}\n" +
                $"L Z2.0\n" +
                $"L Z50.0 FMAX\n" +
                $"L X{1.5+offset} Y5.5 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"L X{2.5+offset}\n" +
                $"L Z2.0\n" +
                $"L Z50.0 FMAX");

            return finalCode;
        }
    }
}
