namespace Program
{
    class code
    {
        static void Main(string[] args)
            {
              Thread threadOne = new Thread(ItUp);
              Thread threadTwo = new Thread(ItDown);

              threadOne.Start();
              threadTwo.Start();
            }
        
        static void ItUp()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Counting up: {i}");
                Thread.Sleep(2000);
            }
            Console.WriteLine("Counting up sequence completed!");
        }

        static void ItDown()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"Counting down: {i}");
                Thread.Sleep(2000);
            }
            Console.WriteLine("Counting down sequence completed!");
        }
    }
}