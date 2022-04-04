using System;

namespace Topic_7_Structs_UnitTests
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region STRUCTS 

            //BE KONSTRUKTORIAUS
            Person person;
            person.Name = "Petras";
            person.Lastname = "Petrauskas";
            person.Age = 28;
            person.SayMyFullName();

            Person person1;
            person1.Name = "Jonas";
            person1.Lastname = "Jonauskas";
            person1.Age = 30;
            person1.SayMyFullName();

            //SU KONSTRUKTORIUMI
            string name = "Petras_CTOR";
            Person person2 = new Person(name, "Petrauskas_CTOR", 35);
            person2.SayMyFullName();


            //Užduotis
            Mokinys mokinys;
            mokinys.Semestras1 = 8;
            mokinys.Semestras2 = 4;
            mokinys.Semestras3 = 7;
            int vidurkis = mokinys.MetinisVidurkis();

            Mokinys mokinysCtor = new Mokinys(8, 4, 7);
            mokinysCtor.MetinisVidurkis();





            #endregion

            #region Unit Tests



            #endregion
        }

        public static decimal CalculateTax(decimal income) 
        {
            decimal result = 0;

            if (income <= 40000)
            {
                result = income * 0.05m;
            }
            else if (income > 40000 && income <= 100000)
            {
                result = income * 0.15m;
            }
            else 
            {
                result = income * 0.25m;
            }

            return result;
        }
    }
}
