using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5Todolist
{
    class ListItem
    {
        public string Name { get; set; }
        public int Difficulty { get; set; }

        Priority pName;

        public ListItem()
        {
            Console.WriteLine("Please enter task name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter Priority (High, Medium, Low)");
            Enum.TryParse(Console.ReadLine(), out Priority pName);
            Console.WriteLine("Please enter Difficulty (Difficult, Medium, Easy)");
            string DiffString = Console.ReadLine();
            if (DiffString == "Difficult")
            {
                Difficulty = 4;
            }
            else if (DiffString == "Medium")
            {
                Difficulty = 2;
            }
            else if (DiffString == "Easy")
            {
                Difficulty = 1;
            }
        }


    }

    enum Priority
    {
        High,
        Medium,
        Low
    }
}
