namespace Topic_6_Interfaces
{
    public abstract class AbstractPizza
    {
        public abstract int Value { get; set; }

        public abstract void Prepare();

        public virtual void MakeSauce() 
        {
            System.Console.WriteLine("Making some kind of sauce");
        }
    }
}
