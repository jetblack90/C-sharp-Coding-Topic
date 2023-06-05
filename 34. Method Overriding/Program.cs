namespace _34._Method_Overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal genericAnimal = new Animal();
            Cat cat = new Cat();
            Dog dog = new Dog();

            genericAnimal.MakeSound();
            cat.MakeSound();
            dog.MakeSound();
        }
    }
}