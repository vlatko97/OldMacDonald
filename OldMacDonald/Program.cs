using System.Text.Json;
using OldMacDonald.Animals;
using System.Runtime.CompilerServices;

namespace OldMacDonald
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionOnePolymorphism();
            QuestionOneDataDriven();
            QuestionTwoExtendBy10Animals();
            QuestionThreeUserInputAnimals();
        }
        private static void QuestionOnePolymorphism()
        {
            Console.WriteLine("Question One Polymorphism:");
            Console.WriteLine("--------------------------");
            Animal Cat = new Cat();
            Cat.Sing();
            Animal Cow = new Cow();
            Cow.Sing();
            Animal Dog = new Dog();
            Dog.Sing();
            Animal Frog = new Frog();
            Frog.Sing();
            Animal Pig = new Pig();
            Pig.Sing();
        }
        private static void QuestionOneDataDriven()
        {
            Console.WriteLine("Question One Data Driven:");
            Console.WriteLine("-------------------------");
            string pathToDataFile = "../../../Data/Animals.json";
            List<Animal> dataDrivenAnimals = ReadFromJson(pathToDataFile);
            MultipleSing(dataDrivenAnimals);
        }
        private static void QuestionTwoExtendBy10Animals()
        {
            Console.WriteLine("Question Two - extend program with 10 more animals:");
            Console.WriteLine("---------------------------------------------------");
            string pathToDataFile = "../../../Data/Animals.json";
            List<Animal> dataDrivenAnimals = ReadFromJson(pathToDataFile);
            dataDrivenAnimals.Add(new Animal("bear", "roar"));
            dataDrivenAnimals.Add(new Animal("bee", "buzz"));
            dataDrivenAnimals.Add(new Animal("donkey", "hee-haw"));
            dataDrivenAnimals.Add(new Animal("snake", "hiss"));
            dataDrivenAnimals.Add(new Animal("duck", "quack"));
            dataDrivenAnimals.Add(new Animal("bird", "tweet"));
            dataDrivenAnimals.Add(new Animal("mouse", "squeek"));
            dataDrivenAnimals.Add(new Animal("elephant", "toot"));
            dataDrivenAnimals.Add(new Animal("fish", "blub"));
            dataDrivenAnimals.Add(new Animal("seal", "ow ow ow"));
            MultipleSing(dataDrivenAnimals);
        }
        private static void QuestionThreeUserInputAnimals()
        {
            Console.WriteLine("Question Three - user input animals:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Enter number of animals:");
            String NumberOfAnimalsLine = Console.ReadLine();
            int NumberOfAnimals;
            if (Int32.TryParse(NumberOfAnimalsLine, out NumberOfAnimals))
            {
                List<Animal> animalsList = [];
                for (int i = 0; i < NumberOfAnimals; ++i)
                {
                    Console.WriteLine("Enter animal name:");
                    String Name = Console.ReadLine();
                    Console.WriteLine("Enter animal sound:");
                    String Sound = Console.ReadLine();
                    animalsList.Add(new Animal(Name,Sound));
                }
                MultipleSing(animalsList);
            }
            else
            {
                Console.WriteLine("Invalid format for number of animals");
                return;
            }
        }
        private static List<Animal> ReadFromJson(string pathToFile)
        {
            string jsonString = File.ReadAllText(pathToFile);
            var jsonData = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(jsonString);
            List<Animal> animalsList = [];

            if (jsonData != null && jsonData.ContainsKey("Animals"))
            {
                var animals = jsonData["Animals"];
                foreach (var animal in animals)
                {
                    animalsList.Add(new Animal(animal.Key, animal.Value));
                }
            }
            return animalsList;
        }
        private static void MultipleSing(List<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                animal.Sing();
            }
        }
    }
}

