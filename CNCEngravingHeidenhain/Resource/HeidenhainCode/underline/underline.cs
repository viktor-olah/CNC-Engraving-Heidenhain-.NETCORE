﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CNCEngravingHeidenhain.Resource.HeidenhainCode.underline
{
    class underline
    {
        public static string ModifiCode(int offset)
        {
            string finalCode = String.Format($"L X{0.5+offset} Y0.0 FMAX\n" +
                $"L Z50.0 FMAX\n" +
                $"L Z2.0 FMAX\n" +
                $"L Z-0.2 FAUTO\n" +
                $"L X{6.5+offset}\n" +
                $"L Z2.0\n" +
                $"L Z50.0 FMAX");

            return finalCode;
        }
    }
}
