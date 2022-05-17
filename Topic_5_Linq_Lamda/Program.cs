using System;
using System.Collections.Generic;
using System.Linq;

namespace Topic_5_Linq_Lamda
{
    class Program
    {
        public class Human
        {
            public string Name { get; set; }
            public string Lastname { get; set; }
            public int Age { get; set; }
            public bool isHuman { get; set; }

            public List<Animal> Animals { get; set; }
        }

        public class Animal
        {
            public string Name { get; set; }
        }

        public class HumanEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Lastname { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            //1. First param is input
            //2. Second param is output
            Func<string, string> selector = str => str.ToUpper();
            string[] words = { "orange", "apple", "article", "dog" };

            //SELECT
            var upperWords = words.Select(selector);
            var upperWords2 = words.Select(s => s.ToUpper());

            //WHERE
            var wordsWhere = words.Where(s => s.Contains("orange"));

            var example = new Example();
            var result = example.MyOwnIterator(words);

            //IEnumerable
            var wordsList = wordsWhere.ToList();
            var resultList = result.ToList();

            //OrderBy/OrderByDescending
            var humans = new List<Human> {
                new Human { Name = "John" },
                new Human { Name = "Tom" },
                new Human { Name = "John" } };
            var orderedHumansAscending = humans.OrderBy(h => h.Name);
            var orderedHumansDescending = humans.OrderByDescending(h => h.Name);

            //FirstOrDefault/SingleOrDefault -- returns null in case does not match

            //FirstOrDefault 
            Human john = humans.FirstOrDefault(h => h.Name == "John");

            //SingleOrDefault
            Human tom = humans.SingleOrDefault(h => h.Name == "Tom");

            //First/Single
            //Human joe = humans.First(h => h.Name == "Joe");
            //Human joeSingle = humans.Single(h => h.Name == "Joe");

            var humanEntities = new List<HumanEntity> {
            new HumanEntity {Id = 1, Name = "John" },
            new HumanEntity {Id = 2, Name = "Tom" },
            new HumanEntity {Id = 3, Name = "Joe" }};


            //SELECT use cases.
            var humansSelected = humanEntities.Select(h => new
            {
                h.Name,
                h.Lastname,
                h.Age
            });

            var humansSelected2 = humanEntities.Select(h => new Human
            {
                Name = h.Name,
                Lastname = h.Lastname,
                Age = h.Age
            });

            var humansSelected3 = humanEntities.Select(h =>
            {
                var t = h.Lastname;
                bool isHuman = h.Lastname + h.Name == "SomeName";

                return new Human
                {
                    Name = h.Name,
                    Lastname = h.Lastname,
                    Age = h.Age,
                    isHuman = isHuman
                };
            });

            //SEELECT MANY uses cases

            var humansWithAnimals = new List<Human>
            {
                new Human
                {
                    Name = "John",
                    Animals = new List<Animal>
                    {
                        new Animal
                        {
                            Name = "Cat"
                        }
                    }
                },
                new Human
                {
                    Name = "Tom",
                    Animals = new List<Animal>
                    {
                        new Animal
                        {
                            Name = "Cat"
                        },
                        new Animal
                        {
                            Name = "Dog"
                        }
                    }
                },
                new Human
                {
                    Name = "John",
                    Animals = new List<Animal>
                    {
                        new Animal
                        {
                            Name = "Monkey"
                        },
                        new Animal
                        {
                            Name = "Tinger"
                        }
                    }
                }
            };

            var humansWithAnimalsSelect = humansWithAnimals.SelectMany(x => x.Animals);
        }
    }
}
