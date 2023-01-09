namespace Program
{
    class code
    {
        static void Main(string[] args)
            {
                Car car = new Car("Toyota", "red");
                Color(car, "yellow");
                Console.WriteLine($"Car make is: {car.make} & Car color is {car.color}");
            }

        public static void Color(Car car, string color)
        {
            car.color = color;
        }
    }

    class Car
    {
        public string make;
        public string color;

        public Car(string make, string color)
        {
            this.make = make;
            this.color = color;
        }
    }
}