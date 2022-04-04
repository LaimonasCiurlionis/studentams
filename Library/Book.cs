using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public struct Book
    {
        private string _name;
        private string _id;

        public string Name //Properties
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                CreateLocalId();
            }
        }

        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                CreateLocalId();
            }
        }

        public string LocalId { get; private set; }

        public Book(string name, string id)
        {
            _name = name;
            _id = id;
            LocalId = string.Empty;
            CreateLocalId();
        }

        private void CreateLocalId() 
        {
            LocalId = string.Format("{0}_{1}", Name, Id);
        }
    }
}
