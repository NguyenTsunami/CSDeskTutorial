using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DemoCollection.model
{
    class Student
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public Student()
        {

        }

        public Student(string name)
        {
            this.Name = name;
        }

    }
    public class SortByName : IComparer
    {
        int IComparer.Compare(object a, object b)
        {
            Student c1 = (Student)a;
            Student c2 = (Student)b;
            return String.Compare(c1.Name, c2.Name, false);
        }
    }


}
