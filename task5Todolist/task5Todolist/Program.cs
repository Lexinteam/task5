using System;
using System.Collections.Generic;

namespace task5Todolist
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<ListItem> listItems = new List<ListItem>();



            do
            {

                listItems.Add(new ListItem());

                Console.WriteLine("\nWould you like to add another task? Y/N");

                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            while (true);

            int timeAll = 0;


            foreach (var i in listItems)
            {
                timeAll += i.Difficulty;
            }

            // to solve question marks instead of russian chars
            Console.WriteLine("сколько всего времени нужно для выполнения всех задач" + timeAll + "часов");

            // TODO 
            //-список задач заданного приоритета(приоритет ввести с клавиатуры)
            //- какие задачи возможно сделать за N дней с учетом приоритета(N ввести с клавиатуры)

            //Console.WriteLine("\n" + listItems.Count);


        }
    }
}
