using System;
using System.Collections.Generic;

namespace Topic_1_Generics
{
    public class MySelfMadeList<T>
    {
        private T[] MyArray { get; set; }
        private int Index = 0;
        private int Size = 10;

        public MySelfMadeList()
        {
            MyArray = new T[Size];
        }


        public void AddItem(T item)
        {
            if (CheckIfNull())
            {
                MyArray = IncreaseArraySize();
            }

            if (item != null)
            {
                MyArray[Index] = item;
                Index++;
            }
            else
            {
                throw new System.ArgumentNullException(nameof(item));
            }
        }

        private bool CheckIfNull()
        {
            return Index == Size;

            //if (Index == Size)
            //{
            //    return true;
            //}
            //else 
            //{
            //    return false;
            //}
        }

        private T[] IncreaseArraySize()
        {
            Size += (Size / 2);
            var newArray = new T[Size];
            MyArray.CopyTo(newArray, 0);
            return newArray;
        }
    }

    public class GenericClass<T1, T2>
    {
        private T1 MyProperty { get; set; }
        private T2 MyProperty2 { get; set; }

        public void PrintT1()
        {
            Console.WriteLine(MyProperty);
        }

        public void PrintT2()
        {
            Console.WriteLine(MyProperty2);
        }

        public T1 ChangeT1Value(T1 value)
        {
            MyProperty = value;
            return value;
        }

        public T2 ChangeT2Value(T2 value)
        {
            MyProperty2 = value;
            return value;
        }
    }

    public class SportsLeague<B, F, V>
        where B : BasktetballTeam
        where F : FootballTeam
        where V : Volleyball
    {
        private List<B> BasketballTeams { get; set; }
        private List<F> FootballTeams { get; set; }
        private List<V> Volleyball { get; set; }

        public void Add(B team)
        {
            BasketballTeams.Add(team);
        }

        public void Add(F team)
        {
            FootballTeams.Add(team);
        }

        public void Add(V team)
        {
            Volleyball.Add(team);
        }
    }

    public class SportsLeagueII<B, F, V>
    {
        private List<BasktetballTeam> BasketballTeams { get; set; }
        private List<FootballTeam> FootballTeams { get; set; }
        private List<Volleyball> Volleyball { get; set; }

        public SportsLeagueII()
        {
            BasketballTeams = new List<BasktetballTeam>();
        }

        public void Add(object team)
        {
            var t = typeof(BasktetballTeam);
            var t1 = team.GetType();

            if (team.GetType() == typeof(BasktetballTeam))
            {
                BasketballTeams.Add((BasktetballTeam)team);
            }
            else
            {
                throw new InvalidCastException();
            }
        }
    }

    public class BasktetballTeam
    {

    }

    public class FootballTeam
    {

    }

    public class Volleyball
    {

    }
}
