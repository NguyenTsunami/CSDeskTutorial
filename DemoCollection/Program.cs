using System;

namespace DemoCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentList list = new StudentList();
            list.acceptDetail();
            list.displayDetail();
            list.sort();
        }
    }
}
