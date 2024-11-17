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
        }
        private static void QuestionOnePolymorphism()
        {
            Console.WriteLine("Question One Polymorphism:");
            Console.WriteLine("-------------------------");
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
            List<Animal> dataDrivenAnimals = readFromJson(pathToDataFile);
            foreach (Animal animal in dataDrivenAnimals)
            {
                animal.Sing();
            }
        }
        private static List<Animal> readFromJson(string pathToFile)
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
    }
}

