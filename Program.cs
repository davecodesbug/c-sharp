namespace Program
{
    class code
    {
        static void Main(string[] args)
            {
              Person person = new Person("Dave", 23);
              Console.WriteLine(person);
            }
    }

    class Person
    {
        string? name;
        int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{name} is {age} years old!";
        }
    }
}