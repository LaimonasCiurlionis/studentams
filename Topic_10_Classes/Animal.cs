namespace Topic_10_Classes
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void SayName() 
        {
            System.Console.WriteLine($"My name is: {Name}");
        }

        public void CountAge() 
        { 
            //CalculatesAge
        }
    }
}
