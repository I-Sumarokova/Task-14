using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(); 
            cat.Name = "Кошка";
            cat.ShowInfo();
            cat.Say();

            Dog dog = new Dog();
            dog.Name = "Собака";
            dog.ShowInfo();
            dog.Say();

            Console.ReadKey();
        }
    }
    public abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal()
        {

        }

        public abstract void Say();
        public void ShowInfo() 
        {
            Console.WriteLine("Животное - {0}",Name);
        }
    }
   

    public class Cat : Animal
    { 
        string name;

        public Cat()
            : base()
        {
            
        }
        public override void Say() 
        {
            Console.WriteLine("Голос - Мяу");
        }
        public override string Name 
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }

    public class Dog:Animal
    {
        string name;

        public Dog()
            : base()
        {
           
        }
        public override void Say()
        {
            Console.WriteLine("Голос - Гав");
        }
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }

}
