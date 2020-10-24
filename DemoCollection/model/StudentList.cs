using DemoCollection.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DemoCollection
{
    class StudentList
    {
        private ArrayList list { get; set; }

        public StudentList()
        {
            list = new ArrayList();
        }

        public void acceptDetail()
        {
            do
            {
                Console.Write("Enter student name: ");
                string name = Console.ReadLine();
                list.Add(new Student(name));

                string choice;
                do
                {
                    Console.Write("Do you want to add more names? [Y/N] : ");
                    choice = Console.ReadLine();
                    if (choice == "Y" || choice == "N" || choice == "y" || choice == "n")
                    {
                        break;
                    }
                } while (true);

                if (choice == "N" || choice == "n")
                {
                    break;
                }
            } while (true);
            Console.WriteLine();
        }

        public void displayDetail()
        {
            Console.WriteLine("List of students:");
            foreach (Student s in list)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine("Total number of students: " + list.Count);
            Console.WriteLine();
        }

        public int selectMenu()
        {
            Console.WriteLine("Select one of the following options: ");
            Console.WriteLine("\t1. Sort");
            Console.WriteLine("\t2. Remove");
            Console.WriteLine("\t3. Reverse");
            Console.WriteLine("\t4. Search");
            Console.WriteLine("\t5. Exit");

            do
            {
                Console.Write("Enter your choice: ");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice >= 1 && choice <= 5)
                    {
                        return choice;
                    }
                }
                catch (Exception ex)
                {

                }

            } while (true);

        }

        public void sort()
        {
            list.Sort(new SortByName());
            Console.WriteLine("-----After Sorting-----");
            displayDetail();
        }

    }
}
