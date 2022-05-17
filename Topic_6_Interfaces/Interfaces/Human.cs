namespace Topic_6_Interfaces
{
    public class Human : ICanRun, ICanEat
    {
        public string GetRunnerName(string name)
        {
            System.Console.WriteLine($"Runner name is: {name}");
            return name;
        }

        public void Run()
        {
            System.Console.WriteLine("I'm running");
        }

        public void HumanMethod() 
        {
            System.Console.WriteLine("Hello from Human class");
        }

        public void Eat()
        {
            System.Console.WriteLine("I'm eating");
        }
    }
}
