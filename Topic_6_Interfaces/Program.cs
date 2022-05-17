using System;
using System.Collections.Generic;

namespace Topic_6_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //POWER OF INTERFACES
            var pizzas = new List<IPizza> { new NewYorkPizza(), new CheesePizza() };

            pizzas.ForEach(pizza => pizza.Prepare());

            //POWER OF COMPARER
            var bmwCars = new List<BmwCar> { new BmwCar ("Model5", true, 5 ), new BmwCar("Model1", false, 5) , new BmwCar("Model99", true, 5) };
            var carComparer = new BmwCarComparer();

            bmwCars.Sort(carComparer);

            var bmwCar = new BmwCar("Model5", true, 5);
            var bmwCar2 = new BmwCar("Model5", true, 5);

            bool isEqual = bmwCar.Equals(bmwCar2);

            var animals = new List<Animal> { new Cat { Name = "Cat1" }, new Cat { Name = "Cat2" }, new Dog { Name = "Dog1" } };
            animals.Sort();
        }
    }

    public interface IAnimal 
    {
        void Eat();
    }

    public interface IMammal 
    {
        void GiveBirth();
    }

    public class Animal : IAnimal, IComparable<Animal>
    {
        public string Name { get; set; }

        public int CompareTo(Animal other)
        {
            return Name.CompareTo(other.Name);
        }

        public virtual void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    public class Dog : Animal, IMammal
    {
        public override void Eat()
        {
            Console.WriteLine("DOG is eating. AU AU.");
        }

        public void GiveBirth()
        {
            Console.WriteLine("DOG is giving brith. AU AU.");
        }
    }

    public class Cat : Animal, IMammal 
    {
        public override void Eat()
        {
            Console.WriteLine("CAT is eating. MIAUW MIAUW.");
        }

        public void GiveBirth()
        {
            Console.WriteLine("CAT is giving brith. MIAUW MIAUW.");
        }
    }
}
