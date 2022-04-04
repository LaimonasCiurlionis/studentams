using System;
using System.Collections.Generic;

namespace Tema_5_Methodai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int num1 = 5;
            int num2 = 10;

            //Return Methodai
            int sum = AddTwoNumbers(5, 10);
            int sum2 = AddTwoNumbers(num1, num2);

            //Void Methodai
            List<string> stringList = new List<string>();
            AddToList(stringList, "Vilnius");
            AddToList(stringList, "Kaunas");
            AddToList(stringList, "Klaipeda");

            List<string> stringList1 = AddToList("Vilnius");
            List<string> stringList2 = AddToList("Kaunas");
            List<string> stringList3 = AddToList("Klaipeda");

            //Public ir Private skirtumas
            var testClass = new Test();
            testClass.SayHelloPublic("Jonas");


            MiniCalculator("+", 9, 1);
            MiniCalculator("-", 8, 4);

            MiniCalculator2("+", 9, 1);
            MiniCalculator2("-", 8, 4);

            //NupiestiRemeli(10);
            //NupiestiRemeli(10, 10);

            int sum1 = CalculateSumRecursively(1, 10);

            int num5 = 5;
            int num6 = IncrementByOne(num5);
        }

        #region Basic Methodai

        public static int AddTwoNumbers(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        public static int SubstractTwoNumbers(int x, int y)
        {
            int diff = x - y;
            return diff;
        }

        public static void MiniCalculator(string simbolis, int x, int y)
        {
            switch (simbolis)
            {
                case "+":
                    int sum = AddTwoNumbers(x, y);
                    Console.WriteLine($"Suma yra: {sum}");
                    break;
                case "-":
                    int diff = SubstractTwoNumbers(x, y);
                    Console.WriteLine($"Skirtumas yra: {diff}");
                    break;
                default:
                    Console.WriteLine("Nezinomas simbolis");
                    break;
            }
        }

        //C# 8 Swtich Expression
        public static void MiniCalculator2(string simbolis, int x, int y)
        {
            int result = simbolis switch
            {
                "+" => AddTwoNumbers(x, y),
                "-" => SubstractTwoNumbers(x, y),
                _ => 0
            };

            Console.WriteLine($"Resultas {x} {simbolis} {y} = {result}");
        }

        public static void AddToList(List<string> stringList, string stringToAdd)
        {
            stringList.Add(stringToAdd);
        }

        public static List<string> AddToList(string stringToAdd)
        {
            List<string> stringList = new List<string>();
            stringList.Add(stringToAdd);
            return stringList;
        }

        //REF KEYWORD

        public static int IncrementByOne(int num) 
        {
            return num++;
        }

        #endregion

        #region Methodu perkrovimas (Methods Overloading)

        private static void NupiestiRemeli(int remelioIlgis) 
        {
            Console.Clear();

            int kiekRemelioSimboliuNupiesti = remelioIlgis;
            string remelioSimbolis = "*";
            string tarpelioSimbolis = " ";

            //nupiesime virsutine eilute
            for (int i = 0; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(remelioSimbolis);
            }

            Console.WriteLine();

            //vidurine eilute
            Console.Write("{0}{1}{2}", remelioSimbolis, tarpelioSimbolis, kiekRemelioSimboliuNupiesti);
            int skaiciausIlgis = kiekRemelioSimboliuNupiesti.ToString().Length;
            int kiekTarpuPraleisti = remelioSimbolis.Length * 2 + skaiciausIlgis + tarpelioSimbolis.Length;

            for (int i = kiekTarpuPraleisti; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(tarpelioSimbolis);
            }

            Console.Write(remelioSimbolis);
            Console.WriteLine();

            //apatine eilute
            for (int i = 0; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(remelioSimbolis);
            }

            Console.WriteLine();
        }

        private static void NupiestiRemeli(int remelioIlgis, int remelioPlotis)
        {
            Console.Clear();

            int kiekRemelioSimboliuNupiesti = remelioIlgis;
            int kokiRemelioPlotiNupiesti = remelioPlotis;
            string remelioSimbolis = "*";
            string tarpelioSimbolis = " ";

            //nupiesime virsutine eilute
            for (int i = 0; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(remelioSimbolis);
            }

            Console.WriteLine();

            int kiekTarpuPraleisti = 0;

            for (int i = 0; i < kokiRemelioPlotiNupiesti; i++)
            {
                //vidurine eilute
                Console.WriteLine("{0}{1}{2}", remelioSimbolis, tarpelioSimbolis, kiekRemelioSimboliuNupiesti);
                int skaiciausIlgis = kiekRemelioSimboliuNupiesti.ToString().Length;
                kiekTarpuPraleisti = remelioSimbolis.Length * 2 + skaiciausIlgis + tarpelioSimbolis.Length;
            }

            for (int i = kiekTarpuPraleisti; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(tarpelioSimbolis);
            }

            Console.Write(remelioSimbolis);
            Console.WriteLine();

            //apatine eilute
            for (int i = 0; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(remelioSimbolis);
            }

            Console.WriteLine();
        }

        private static void NupiestiRemeli(int remelioIlgis, string remelioPlotis)
        {
            Console.Clear();

            int kiekRemelioSimboliuNupiesti = remelioIlgis;
            string kokiRemelioPlotiNupiesti = remelioPlotis;
            string remelioSimbolis = "*";
            string tarpelioSimbolis = " ";

            //nupiesime virsutine eilute
            for (int i = 0; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(remelioSimbolis);
            }

            Console.WriteLine();

            int kiekTarpuPraleisti = 0;

            for (int i = 0; i < kokiRemelioPlotiNupiesti.Length; i++)
            {
                //vidurine eilute
                Console.WriteLine("{0}{1}{2}", remelioSimbolis, tarpelioSimbolis, kiekRemelioSimboliuNupiesti);
                int skaiciausIlgis = kiekRemelioSimboliuNupiesti.ToString().Length;
                kiekTarpuPraleisti = remelioSimbolis.Length * 2 + skaiciausIlgis + tarpelioSimbolis.Length;
            }

            for (int i = kiekTarpuPraleisti; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(tarpelioSimbolis);
            }

            Console.Write(remelioSimbolis);
            Console.WriteLine();

            //apatine eilute
            for (int i = 0; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(remelioSimbolis);
            }

            Console.WriteLine();
        }

        private static void NupiestiRemeli(string remelioIlgis, int remelioPlotis)
        {
            Console.Clear();

            int kiekRemelioSimboliuNupiesti = remelioIlgis.Length;
            int kokiRemelioPlotiNupiesti = remelioPlotis;
            string remelioSimbolis = "*";
            string tarpelioSimbolis = " ";

            //nupiesime virsutine eilute
            for (int i = 0; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(remelioSimbolis);
            }

            Console.WriteLine();

            int kiekTarpuPraleisti = 0;

            for (int i = 0; i < kokiRemelioPlotiNupiesti; i++)
            {
                //vidurine eilute
                Console.WriteLine("{0}{1}{2}", remelioSimbolis, tarpelioSimbolis, kiekRemelioSimboliuNupiesti);
                int skaiciausIlgis = kiekRemelioSimboliuNupiesti.ToString().Length;
                kiekTarpuPraleisti = remelioSimbolis.Length * 2 + skaiciausIlgis + tarpelioSimbolis.Length;
            }

            for (int i = kiekTarpuPraleisti; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(tarpelioSimbolis);
            }

            Console.Write(remelioSimbolis);
            Console.WriteLine();

            //apatine eilute
            for (int i = 0; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(remelioSimbolis);
            }

            Console.WriteLine();
        }
        #endregion

        #region Rekursija 

        private static int CalculateSumRecursively(int x, int y) 
        {
            int sum = x;

            if (x < y) 
            {
                x++;
                return sum += CalculateSumRecursively(x, y);
            }

            return sum;
        }

        #endregion

    }
}
