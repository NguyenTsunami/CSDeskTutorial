using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class Cat:Animal
    {
        public int age { get; set; }
        public int height { get; set; }

        public Cat():base()
        {
            age = 0;
            height = 0;
            Console.WriteLine("Cat - " + age + " - " + height + " - created!");
        }

        public Cat(String name, int age, int height):base(name)
        {
            this.age = age;
            this.height = height;
            Console.WriteLine("Cat - " + age + " - " + height + " - created!");
        }

        public Cat(int age, int height):base()
        {
            this.age = age;
            this.height = height;
            Console.WriteLine("Cat - " + age + " - " + height + " - created!");
        }


        public void haughty()
        {
            Console.WriteLine("I am boss, where is my sen?");
        }

        public void sleep()
        {
            Console.WriteLine("Meow sleep ..zzz..");
        }

        public override void move()
        {
            Console.WriteLine("Meow move!!! Get out of the way!!!");
        }
    }
}
