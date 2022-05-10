using System;
using System.Collections.Generic;

namespace Topic_3_Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, this is my first extension method";

            //Method chaining
            var result = str
                .PrintString()
                .PrintString2();

            int num = 5;
            num.PrintIntValue();

            int sum = num.AddAndPrintValue(num);
        }


        //THIS keyword
        public class Human 
        {
            public string Name { get; set; }
            public string Lastname { get; set; }

            public Human()
            {

            }

            public Human(string name, string lastname)
            {
                this.Name = name;
                this.Lastname = lastname;
            }
        }
    }

    //Extension method class
    public static class MyExensions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string PrintString(this string str)
        {
            Console.WriteLine(str);
            return str;
        }

        public static string PrintString2(this string str)
        {
            Console.WriteLine(str);
            return str;
        }

        public static void PrintIntValue(this int num) 
        {
            Console.WriteLine(num);
        }

        public static int AddAndPrintValue(this int num, int num2)
        {
            int sum = num + num2;
            Console.WriteLine(sum);
            return sum;
        }

        public static void FileExtension(this System.IO.File file) { }
    }




}
