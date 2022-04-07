using System;
using System.Collections.Generic;

namespace Topic_9_CleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //BAD

            int d; //zmogaus amzius
            int sum2; //rinkejuSkaicius

            //GOOD
            int PersonAge;
            int age;
            int amzius;
            int rinkejuSkaicius;

            //BAD
            int[] accountsArray = new int[] { 1, 2, 3 };
            List<int> accountsList = new List<int>();

            //GOOD
            int[] accounts = new int[] { 1, 2, 3 };
            //List<int> accounts = new List<int>();

            //THE, INFO, DATA, VARIABLE, OBJECT, MANAGER => AVOID USING THIS NAMING

            //BAD
            var yyyymmd = DateTime.Now;

            //GOOD
            var currentDate = DateTime.Now;
            var dateNow = DateTime.Now;

            //BAD
            int vartotojoAmzius = 10;

            if (vartotojoAmzius >= 20) 
            { 
                //kazkas
            }

            if (vartotojoAmzius < 20)
            {
                //kazkas
            }

            if (vartotojoAmzius == 20)
            {
                //kazkas
            }

            //GOOD
            int _amzius = 18;

            if (vartotojoAmzius >= _amzius)
            {
                //kazkas
            }

            if (vartotojoAmzius < _amzius)
            {
                //kazkas
            }

            if (vartotojoAmzius == _amzius)
            {
                //kazkas
            }

            //BAD
            bool isChild;

            string name = "Jonas";

            if (name == "Jonas")
            {
                isChild = true;
            }
            else 
            {
                isChild = false;
            }

            //GOOD
            isChild = name == "Jonas";
        }
    }
}
