using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;


namespace CNCEngravingHeidenhain
{
     class Program
    {

        static string inputString;
        static string filename;
        
        static char whiteSpace = ' ';


        static void Main(string[] args)
        {
            int defaultOffset = 0;
                
                Console.WriteLine("File name?");
                filename = Console.ReadLine().Trim(whiteSpace);

                Console.WriteLine("Gravir text?");
                inputString = Console.ReadLine().Trim(whiteSpace).ToLower();
            
           


            foreach (char item in inputString)
            {
                Letter.LetterCode(item, defaultOffset, filename);
                defaultOffset = defaultOffset + 8;
            }


            //Final check
            CNCFileGenerator.FileStatus(filename);

            Console.ReadKey();
        }
    }
}
