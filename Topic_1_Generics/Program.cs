using System;
using System.Collections.Generic;

namespace Topic_1_Generics
{
    class Program
    {
        public class Human 
        {
            public string Name { get; set; }
            public string Lastname { get; set; }

            //implementuojam ToString methoda per override. Tai galime padaryti, kadangi jis yra Virtual
            public override string ToString()
            {
                return $"{Name}, {Lastname}";
            }
        }

        public struct HumanStruct 
        {
            public string Name { get; set; }
            public string Lastname { get; set; }
        }


        static void Main(string[] args)
        {
            //Kvieciame geneneric methoda
            ShowItem<string>("name");
            ShowItem<int>(5);
            ShowItem<Human>(new Human { Name = "John", Lastname = "Doe" });

            GetItemType<Human>(new Human { Name = "John", Lastname = "Doe" });
            GetItemType<string>("string");
            GetItemType<int>(5);


            //Kvieciame Generic class
            var selftMadeList = new MySelfMadeList<int>();
            for (int i = 0; i < 1000; i++)
            {
                selftMadeList.AddItem(i);
            }


            //BLOGAI! VENGTI NAUDOTI!
            List<object> intList = new List<object>();
            intList.Add(1);
            intList.Add(1);
            var x = (int)intList[0];
            
            List<object> stringList = new List<object>();
            stringList.Add("stringas");
            stringList.Add("stringas2");

            List<object> humanList = new List<object>();
            humanList.Add(new Human {Name = "John", Lastname = "Doe" });
            humanList.Add(new Human {Name = "John", Lastname = "Doe" });


            //GENERIC CONSTRAINTS
            var orderRepo = new OrderRepository();
            var baseRepo = new BaseRepository<Order>(new List<Order> { new Order { Id = 1, Name = "Test" } });
            var result = baseRepo.Get();

            var structRepo = new BaseRepositoryStruct<HumanStruct>();

            var genericClass = new GenericClass<Human, Human>();

            var sportsLeagueII = new SportsLeagueII<BasktetballTeam, int, string>();

            sportsLeagueII.Add(new BasktetballTeam());
            sportsLeagueII.Add(5);
        }

        //Generic methods
        public static void ShowItem<T>(T item) 
        {
            Console.WriteLine("Item: {0}", item);
        }

        public static void GetItemType<T>(T item)
        {
            Console.WriteLine(item.GetType().Name);
        }
    }
}
