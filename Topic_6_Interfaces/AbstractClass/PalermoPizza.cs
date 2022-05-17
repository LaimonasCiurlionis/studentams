namespace Topic_6_Interfaces
{
    public class PalermoPizza : AbstractPizza
    {
        private PalermoPizza()
        {

        }

        public override int Value { get; set; }

        public override void Prepare()
        {
            System.Console.WriteLine("Preparing PalermoPizza");
        }

        public override void MakeSauce()
        {
            System.Console.WriteLine("Making sauce with special italian recepie");
        }
    }
}
