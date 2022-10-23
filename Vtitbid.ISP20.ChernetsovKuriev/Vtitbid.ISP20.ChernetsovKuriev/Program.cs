using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.ChernetsovKuriev.Route
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите количество маршрутов:");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                Route[] array = Route.GetNumberOfRoutes(value);  // (1)
                Console.WriteLine();
                array = Route.SortRoutes(array);
                foreach (var route in array)
                {
                    Console.WriteLine(route);
                    Console.WriteLine();
                }
                Console.WriteLine(Route.SearchRoute(array)); // (4)
            }
            else
            {
                Console.WriteLine("Количесвто маршрутов не опредлено ");
            }
        }
    }
}
