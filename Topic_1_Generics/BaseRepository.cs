using System;
using System.Collections.Generic;
using System.Linq;

namespace Topic_1_Generics
{
    public class BaseRepository<T> where T : Entity, new() //CONSTRAINTS
    {
        private List<T> Items { get; set; }

        public BaseRepository()
        {
            Items = new List<T>();
        }

        public BaseRepository(List<T> items)
        {
            Items = items;
        }

        public T Get(int id)
        {
            return Items.Single(x => x.Id == id);
        }

        public List<T> Get()
        {
            return Items;
        }

        public List<T> GetByDate(DateTime date) 
        {
            return Items.Where(x => x.DateTime == date).ToList();
        }
    }

    public class BaseRepositoryStruct<T> where T : struct 
    { 
        private List<T> items { get; set; }
    }
}
