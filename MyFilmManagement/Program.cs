using System;

namespace MyFilmManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~ MY FILM MANAGEMENT ~~~~~~~~~");
            FilmList list = new FilmList();
            list.inputList();
            list.displayList();
            list.searchViaName();

        }
    }
}
