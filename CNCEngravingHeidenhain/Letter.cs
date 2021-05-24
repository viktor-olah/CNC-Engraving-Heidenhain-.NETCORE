using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CNCEngravingHeidenhain.Resource.HeidenhainCode;

namespace CNCEngravingHeidenhain
{
    public class Letter
    {
        char character;
        public char Character { get => character; set => character = value; }
       

        public Letter(char character)
        {
            Character = character;
        }

        public static void LetterCode (char character, int offset,string filename)
        {

            switch (character)
            {
                case '.':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.dot.dot.ModifiCode(offset), filename);
                    break;
                case '-':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.line.line.ModifiCode(offset), filename);
                    break;
                case '_':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.underline.underline.ModifiCode(offset), filename);
                    break;
                case 'a':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.a.a.ModifiCode(offset), filename);
                    break;
                case 'b':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.b.c.ModifiCode(offset), filename);
                    break;
                case 'c':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.c.c.ModifiCode(offset), filename);
                    break;
                case 'd':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.d.d.ModifiCode(offset), filename);
                    break;
                case 'e':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.e.e.ModifiCode(offset), filename);
                    break;
                case 'f':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.f.f.ModifiCode(offset), filename);
                    break;
                case 'g':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.g.g.ModifiCode(offset), filename);
                    break;
                case 'h':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.h.h.ModifiCode(offset), filename);
                    break;
                case 'i':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.i.i.ModifiCode(offset), filename);
                    break;
                case 'j':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.j.j.ModifiCode(offset), filename);
                    break;
                case 'k':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.k.k.ModifiCode(offset), filename);
                    break;
                case 'l':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.l.l.ModifiCode(offset), filename);
                    break;
                case 'm':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.m.m.ModifiCode(offset), filename);
                    break;
                case 'n':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.n.n.ModifiCode(offset), filename);
                    break;
                case 'o':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.o.o.ModifiCode(offset), filename);
                    break;
                case 'p':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.p.p.ModifiCode(offset), filename);
                    break;
                case 'q':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.q.q.ModifiCode(offset), filename);
                    break;
                case 'r':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.r.r.ModifiCode(offset), filename);
                    break;
                case 's':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.s.s.ModifiCode(offset), filename);
                    break;
                case 't':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.t.t.ModifiCode(offset), filename);
                    break;
                case 'u':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.u.u.ModifiCode(offset), filename);
                    break;
                case 'v':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.v.v.ModifiCode(offset), filename);
                    break;
                case 'w':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.w.w.ModifiCode(offset), filename);
                    break;
                case 'x':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.x.x.ModifiCode(offset), filename);
                    break;
                case 'y':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.y.y.ModifiCode(offset), filename);
                    break;
                case 'z':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode.z.z.ModifiCode(offset), filename);
                    break;
                case '0':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode._0._0.ModifiCode(offset), filename);
                    break;
                case '1':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode._1._1.ModifiCode(offset), filename);
                    break;
                case '2':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode._2._2.ModifiCode(offset), filename);
                    break;
                case '3':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode._3._3.ModifiCode(offset), filename);
                    break;
                case '4':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode._4._4.ModifiCode(offset), filename);
                    break;
                case '5':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode._5._5.ModifiCode(offset), filename);
                    break;
                case '6':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode._6._6.ModifiCode(offset), filename);
                    break;
                case '7':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode._7._7.ModifiCode(offset), filename);
                    break;
                case '8':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode._8._8.ModifiCode(offset), filename);
                    break;
                case '9':
                    CNCFileGenerator.Generator(CNCEngravingHeidenhain.Resource.HeidenhainCode._9._9.ModifiCode(offset), filename);
                    break;

            }
        }
    }
}
