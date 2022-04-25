using System;
using System.Collections.Generic;
using System.Text;

namespace HTML_Generator
{
    public class Generic<T> where T : class, new()
    {
        public List<T> MyData { get; set; }

        public void Add(T entity) 
        {
            MyData.Add(entity);
        }
    }
}
