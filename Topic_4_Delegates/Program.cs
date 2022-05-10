using System;

namespace Topic_4_Delegates
{
    class Program
    {
        static readonly int GlobalNumber = 10;

        //DELEGATES
        private delegate int NumberChanger(int n);
        private delegate string StringChanger(string n);

        //GENERIC DELEGATE
        private delegate string GetType<T>(T type);

        static void Main(string[] args)
        {
            //CREATING DELEGATES
            var numberChanger1 = new NumberChanger(AddNumber);
            var numberChanger2 = new NumberChanger(SubtractNumber);

            //CALLING DELEGATES
            Console.WriteLine(numberChanger1(5));
            Console.WriteLine(numberChanger2(6));

            PassMethod(numberChanger1, 5);
            PassMethod(numberChanger2, 6);

            var myTypeGetter = new GetType<object>(MyGetType);
            var myType = numberChanger2;
            var result = myTypeGetter(myType);

            //Anonymous delegates
            int y = 10;

            NumberChanger changer = delegate (int num)
            {
                return num + y;
            };

            Console.WriteLine(changer(5));

            int x = 5;
            string someString = string.Empty;

            ExecuteNumberChangerWithValue(x, delegate (int value)
            {
                Console.WriteLine(value);
                return value;
            });

            ExecuteNumberChangerWithValue(someString, delegate (string value)
            {
                Console.WriteLine(value);
                return value;
            });
        }

        #region DELEGATE METHODS

        private static int AddNumber(int number)
        {
            return GlobalNumber + number;
        }

        private static int SubtractNumber(int number) 
        {
            return GlobalNumber - number;
        }

        //METHOD WHICH ACCEPTS DELEGATE
        private static void PassMethod(NumberChanger method, int number) 
        {
            Console.WriteLine(method.Invoke(number)); 
        }

        private static string MyGetType<T>(T type) 
        {
            return type.GetType().Name;
        }

        #endregion

        #region Anonymous delegates

        private static void ExecuteNumberChangerWithValue(int value, NumberChanger numberChanger) 
        {
            value += 10;
            numberChanger(value);
        }

        private static void ExecuteNumberChangerWithValue(string value, StringChanger numberChanger)
        {
            numberChanger(value);
        }


        #endregion
    }
}