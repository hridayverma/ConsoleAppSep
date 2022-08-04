using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSep.Inheritance
{
 public  abstract  class Animal
    {
        public abstract void Talk();
        public abstract void Eat();
    }

  internal  class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog eats pedigree");
        }
        public override void Talk()
        {
            Console.WriteLine("bhown-bhown");
        }
    }
    public class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cat eats non-veg");
        }
        public override void Talk()
        {
            Console.WriteLine("meown-meown");
        }
    }
    enum AnimalType
    {
        Dog,Cat,Lion,Tiger
    }
    class AnimalFactory
    {
        public static Animal GetAnimalObject(AnimalType animalType) {
            Animal animal = null;
            switch (animalType) {
                case AnimalType.Dog:
                    animal = new Dog();
                    break;
                case AnimalType.Cat:
                    animal = new Cat();
                    break;
                default:
                    break;
            }
            return animal;
        }
    }

    internal class AbstractDemo
    {
       public static void Main()
        {
            /*
            Dog dog = new Dog();
            dog.Talk();
            dog.Eat();*/

            /*
            Animal animal = new Cat();
            animal.Talk();
            animal.Eat();*/

            Animal animal=AnimalFactory.GetAnimalObject(AnimalType.Dog);
            animal.Talk();
            animal.Eat();

            Dog dog =(Dog) animal;
            dog.Talk();
            dog.Eat();

           // Cat cat = animal as Cat;
           // cat.Talk();

            









        }
    }
}
