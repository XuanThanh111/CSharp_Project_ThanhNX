using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4OOP
{
    /*******************************************/
    // Tính trừu tượng
   public interface Animal
    {
        void hello();
    }
 
    /*****************************************/
    // Tính kế thừa
    public class Dog : Animal
    {
        public void hello()
        {
            Console.WriteLine("It's DOG");
        }
    }
    public class Cat: Animal
    {
        public void hello()
        {
            Console.WriteLine("It's CAT");
        }
    }
    /****************************************/
    // Tính bao đóng
     sealed class Zoo
    {
       // private Animal animal;

        List<Animal> animals = new List<Animal>();
        internal void add(Animal animal)
        {
            animals.Add(animal);
        }
        internal void remove(Animal animal)
        {
            animals.Remove(animal);
        }
        internal void allsayHello()
        {

         Console.WriteLine("=====AllAnimation Hello=====");
            for(int i=0; i<animals.Count();i++)
            {
                animals[i].hello();
            }
        }
    }
    /*****************************************/
    //Tính đa hình
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            Dog dog = new Dog();
            Cat cat = new Cat();
            //no add
            zoo.allsayHello();
            //add dog
            zoo.add(dog);
            zoo.allsayHello();
            //remove cat
            //remove dog
            zoo.remove(cat);
            zoo.remove(dog);
            zoo.allsayHello();
            //add cat
            zoo.add(cat); ;
            zoo.allsayHello();
            Console.ReadKey();
        }
    }
}
