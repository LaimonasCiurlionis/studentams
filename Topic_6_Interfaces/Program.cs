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
        }
    }
}
