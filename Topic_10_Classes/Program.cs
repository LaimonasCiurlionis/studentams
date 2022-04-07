using System;

namespace Topic_10_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //VALUE
            int i;
            i = 50;

            int x = i;
            x = 99;

            //Kas yra i = 50?

            //REFERENCE
            var i1 = new Customer();
            i1.Firstname = "Jonas";

            var x1 = i1;
            x1.Firstname = "Petras";

            //Kas yra i1? 

            //STATIC CLASS
            int sum = StaticClass.GetSum(10, 36);
        }
    }
}
