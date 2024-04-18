using System;
namespace Animals
{
    abstract class Animal
    {

        abstract public string Name { get; set; }


        public abstract string Describe();

        public string whatAmI()
        {
            return "I am an animal";
        }
    }
    class Program
    {
        class Capybara : Animal
        {
            public int Age { get; set; }
            public override string Name { get; set; }
            public string Type { get; set; }

            public Capybara()
            {
                Age = 0;
                Name = string.Empty;
                Type = string.Empty;

            }
            public Capybara(int age, string name, string type)
            {
                Age = age;
                Name = name;
                Type = type;

            }

            public override string Describe()
            {
                return "I am a " + Type + "\nMy name is " + Name;
            }
        }
        static void Main(string[] args)
        {
            Capybara drew = new Capybara();
            drew.Name = "Drew";
            drew.Type = "Capybara";
            drew.Age = 5;
            Console.WriteLine(drew.whatAmI());
            Console.WriteLine(drew.Describe());

            Console.WriteLine();

            Capybara yuhhh = new Capybara();
            yuhhh.Name = "Blud";
            yuhhh.Type = "Capybara";
            yuhhh.Age = 2;
            Console.WriteLine(yuhhh.whatAmI());
            Console.WriteLine(yuhhh.Describe());

            Console.WriteLine();

            Capybara capybara = new Capybara(2, "Jeremiah", "Capybara");
            capybara.Name = "Jeremiah";
            capybara.Type = "Capybara";
            capybara.Age = 3;
            Console.WriteLine(capybara.whatAmI());
            Console.WriteLine(capybara.Describe());

            Console.WriteLine();

            Capybara laptop = new Capybara();
            laptop.Name = "Leapold";
            laptop.Type = "Capybara";
            laptop.Age = 10;
            Console.WriteLine(laptop.whatAmI());
            Console.WriteLine(laptop.Describe());

            Console.WriteLine();

        }
    }
}
