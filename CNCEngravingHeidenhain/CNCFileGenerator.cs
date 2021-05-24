using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CNCEngravingHeidenhain
{
    class CNCFileGenerator
    {


        public static void Generator(string charCode, string filename)
        {

            string path = $"GravirCode/{filename}.H";
            if (!Directory.Exists("GravirCode"))
            {
                Directory.CreateDirectory("GravirCode");
            }
            FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter code = new StreamWriter(file);

           
                code.WriteLine(charCode);
                code.Close();
                file.Close();
            
            
            
        }

        public static string PGMStart(string filename)
        {
            string pgmStart = String.Format($"BEGIN PGM {0} MM\n" +
                $"TOOL CALL 1 Z S9000 F50 DL+0 DR+0\n" +
                $"L Z+200 R0 FMAX M13",filename);

            return pgmStart;
        }
        public static string PGMEnd(string filename)
        {
            string pgmEnd = String.Format($"L Z+200 R0 FMAX M30\n" +
                $"END PGM {0} MM", filename);


            return pgmEnd;
        }
        public static void FileStatus(string filename)
        {
            if (File.Exists($"GravirCode/{filename}.H") == true)
            {
                Console.WriteLine("Code generated!");
            }
            else
            {
                Console.WriteLine("You entered an incorrect character! Please try again!");
            }
     
        }


    }
}
