using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyFilmManagement
{
    class FilmList
    {
        ArrayList list;

        public FilmList()
        {
            list = new ArrayList();
        }

        public void inputList()
        {
            do
            {
                Film film = new Film();
                film.inputData();
                list.Add(film);
                Console.WriteLine(film + " => Add Done!");

                String option = "";
                do
                {
                    Console.Write("Do you want to add more film? (Y/N) - ");
                    option = Console.ReadLine();

                    if (option != "Y" && option != "N" && option != "y" && option != "n")
                    {
                        Console.WriteLine("Please enter Y/N!");
                    }
                    else
                    {
                        break;
                    }
                }
                while (true);

                if (option == "N" || option == "n")
                {
                    break;
                }
            }
            while (true);
        }

        public void displayList()
        {
            foreach (Film film in list)
            {
                Console.WriteLine(film);
            }
        }

        public void searchViaName()
        {
            ArrayList found = new ArrayList();

            Console.Write("Enter name to search: ");
            String name = Console.ReadLine();

            foreach (Film film in list)
            {
                if (film.SName.Equals(name))
                {
                    found.Add(film);
                }
            }

            if (found.Count == 0)
            {
                Console.WriteLine("No film found!");
            }
            else
            {
                Console.WriteLine("All film has name " + name + ": ");
                foreach (Film film in found)
                {
                    Console.WriteLine(film);
                }
            }
        }

    }
}
