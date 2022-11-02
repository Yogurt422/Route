
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Проблема с проверкой номера маршрута
// Проверка на пробелы в названии начальных и конечных точек(просто пробел засчитывает) тоже и с номером
// Проблема с поиском маршрутов и порядком вывода
namespace Vtitbid.ISP20.ChernetsovKuriev.Route
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите количество маршрутов:");
            bool numbersOfRoute = false;
            do
            {
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    numbersOfRoute = true;
                    Route[] array = Route.GetNumberOfRoutes(value);  // (1)
                    Console.WriteLine();
                    foreach (var route in array)
                    {
                        Console.WriteLine(route);
                        Console.WriteLine();
                    }
                    Console.WriteLine(Route.SearchRoute(array)); // (4)
                }
                else
                {
                    Console.WriteLine("Количество маршрутов не опредлено\nВведите количество маршрутов(число(не словом))");
                }
            }
            while (numbersOfRoute == false);
        }
    }
}