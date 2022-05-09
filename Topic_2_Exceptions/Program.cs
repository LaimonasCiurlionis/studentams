using System;

namespace Topic_2_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var divide = new DivideNumbers();
            divide.Division(25, 0);
            divide.Division(0, 25);

            var temperature = new Temperature();

            try
            {
                temperature.Show();
            }
            catch (TempIsZeroException ex)
            {
                Console.WriteLine($"TempIsZeroException: {ex.Message}"); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Some generic exception: {ex.Message}");
            }
        }
    }

    public class DivideNumbers
    {
        int result = 0;

        public void Division(int num1, int num2) 
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }
            finally 
            {
                Console.WriteLine($"Result: {result}");
            }        
        }
    }

    public class TempIsZeroException : Exception 
    {
        public TempIsZeroException(string message) : base(message)
        {

        }
    }


    public class Temperature 
    {
        int temperature = 1;

        public void Show()
        {
            if (temperature == 0)
            {
                throw new TempIsZeroException("Zero temperature found");
            }
            else 
            {
                throw new NullReferenceException();
            }
        }
    
    }

}
