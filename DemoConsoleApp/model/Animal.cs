using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class Animal
    {
        public String name { get; set; }

        public Animal()
        {
            Console.WriteLine("New animal created!");
        }

        public Animal(String name)
        {
            this.name = name;
            Console.WriteLine("New animal named " + name + " created!");
        }

        public virtual void move()
        {
            Console.WriteLine("Animal move...");
        }

        public void sleep()
        {
            Console.WriteLine("Animal sleep ...zzz...");
        }
    }
}
