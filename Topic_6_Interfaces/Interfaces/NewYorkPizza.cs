using System;

namespace Topic_6_Interfaces
{
    public class NewYorkPizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing New York Pizza");
        }
    }
}
