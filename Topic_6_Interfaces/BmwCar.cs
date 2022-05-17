using System;

namespace Topic_6_Interfaces
{
    public class BmwCar : IEquatable<BmwCar>
    {
        public string Model { get; set; }
        public bool IsXDrive { get; set; }
        public int Fuel { get; set; }

        public BmwCar(string model, bool isXDrive, int fuel)
        {
            Model = model;
            IsXDrive = isXDrive;
            Fuel = fuel;
        }

        public bool Equals(BmwCar other)
        {
            return Model == other.Model;
        }
    }
}
