namespace Topic_6_Interfaces
{
    public class CheesePizza : IPizza
    {
        public void Prepare()
        {
            System.Console.WriteLine("Preparing Cheese Pizza");
        }
    }
}
