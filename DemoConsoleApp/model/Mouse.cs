using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class Mouse : Animal
    {
        public int weight { get; set; }

        public Mouse() : this(10)
        {

        }

        public Mouse(int w)
        {
            this.weight = w;
        }

        public Mouse(String name, int w) : base(name)
        {
            this.weight = w;
        }

        public override void move()
        {
            Console.WriteLine("Mouse move...");
        }

        public void sleep()
        {
            Console.WriteLine("Mouse sleep ..zzz..");
        }
    }
}
