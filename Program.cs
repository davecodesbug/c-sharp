namespace Program
{
    class code
    {
        static void Main(string[] args)
            {
                try {
                Console.WriteLine("Enter number 1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int total = num1 + num2;
                Console.WriteLine(total);
                }
                catch (FormatException err)
                {
                    Console.WriteLine("You can only enter integers!", err);
                }
            }
    }
}