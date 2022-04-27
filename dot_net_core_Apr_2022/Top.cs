using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_core_Apr_2022
{
    public class Top
    {
        public Menu menu { get; set; }

        public void Print()
        {
            Console.WriteLine(menu.header);
            foreach (var item in menu.items)
            {
                if (item == null)
                {
                    Console.WriteLine("\tnull");
                }
                else
                {
                    Console.Write($"\t {item.id} - ");
                    if(item.label != null)
                    {
                        Console.Write($"{item.label}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
