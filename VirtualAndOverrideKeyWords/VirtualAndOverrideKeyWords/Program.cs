namespace VirtualAndOverrideKeyWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Zebra", 13);
            Dog dog = new Dog("Bob", 7);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            dog.Play();
            dog.Eat();
            dog.MakeSound();
        }
    }
}