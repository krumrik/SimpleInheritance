using System;

namespace Inheritance
{
    class Animal
    {
        public string name;

        public Animal()
        {
            name = "";
        }

        public Animal(string name)
        {
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }
    }

    class llama : Animal
    {
        public string species;
        public string color;
        public double height;
        public double weight;

        public llama()
        {
            color = "";
            height = 0;
            weight = 0;
        }

        public llama (string species, string name, string color, double height, double weight) : base(name)
        {
            this.species = species;
            this.color = color;
            this.height = height;
            this.weight = weight;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Weight: {weight}");
        }
    }

    class bear : Animal
    {
        public string species;
        public int age;
        public double height;
        public double weight;

        public bear()
        {
            age = 0;
            height = 0;
            weight = 0;
        }

        public bear(string species, string name, int age, double height, double weight) : base(name)
        {
            this.species = species;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Weight: {weight}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.Display();

            Console.WriteLine();

            llama myNewAnimal1 = new llama();
            myNewAnimal1.species = "Llama";
            myNewAnimal1.name = "Leo the Llama";
            myNewAnimal1.color = "Light Brown";
            myNewAnimal1.height = 10;
            myNewAnimal1.weight = 600;

            Console.WriteLine($"{myNewAnimal1.species} information...");
            myNewAnimal1 .DisplayDetails();

            Console.WriteLine(); 

            bear mybear = new bear("Bear", "Bobby", 12, 8, 400);

            Console.WriteLine($"{mybear.species} information...");
            mybear .DisplayDetails();

            Console.WriteLine();

            llama myNewAnimal2 = new llama("Llama", "Light the Llama", "White", 8, 575);

            Console.WriteLine($"{myNewAnimal2.species} information...");
            myNewAnimal2 .DisplayDetails();

            Console.WriteLine();

            bear mybear1 = new bear("Bear", "Beatrice", 10, 6, 325);

            Console.WriteLine($"{mybear1.species} information...");
            mybear1 .DisplayDetails();   
        }
    }
}

