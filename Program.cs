namespace Program
{
    class code
    {
        static void Main(string[] args)
            {
               Unicycle unicycle = new Unicycle();
               unicycle.wheels();

               Bike bike = new Bike();
               bike.wheels();
            }
    }

    abstract class Vehicle
    {
        public virtual void wheels()
        {
            Console.WriteLine("Vehicle has 4 wheels");
        }
    }

    class Unicycle : Vehicle
    {
        public override void wheels()
        {
            Console.WriteLine("Unicycle has 1 giant wheel");
        }
    }

    class Bike : Vehicle
    {
        public override void wheels()
        {
            Console.WriteLine("Bike has 2 wheels");
        }
    }
}