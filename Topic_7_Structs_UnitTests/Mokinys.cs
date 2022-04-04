using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_7_Structs_UnitTests
{
    public struct Mokinys
    {
        public int Semestras1;
        public int Semestras2;
        public int Semestras3;

        public Mokinys(int semestras1, int semestras2, int semestras3)
        {
            Semestras1 = semestras1;
            Semestras2 = semestras2;
            Semestras3 = semestras3;
        }

        public int MetinisVidurkis() 
        {
            return (Semestras1 + Semestras2 + Semestras3) / 3;
        }
    }
}
