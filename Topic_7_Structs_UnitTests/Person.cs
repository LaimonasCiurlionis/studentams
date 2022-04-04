using System;

namespace Topic_7_Structs_UnitTests
{
    public struct Person
    {
        public string Name;
        public string Lastname;
        public int Age;

        public Person(string name, string lastname, int age) 
        {
            Name = name;
            Lastname = lastname;
            Age = age;
        }

        public void SayMyFullName() 
        {
           Console.WriteLine($"My name is: {Name} and my lastname is: {Lastname}");
        }
    }
}
