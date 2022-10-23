using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.ChernetsovKuriev.Route
{
    public class Route
    {
        public string StartOfRouteName { get; set; }
        public string EndOfRouteName { get; set; }
        public int NumberOfRoute { get; set; }

        public Route(string startOfRouteName, string endOfRouteName, int numberOfRoute)
        {
            StartOfRouteName = startOfRouteName;
            EndOfRouteName = endOfRouteName;
            NumberOfRoute = numberOfRoute;
        }

        public static Route RouteCreate() // Заполнение (2)
        {
            Console.Write("Введите начало маршрута: ");
            var nameStartOfRoute = CheckName(Console.ReadLine(), nameof(StartOfRouteName));   // Проверка на маршрут (3)
            Console.Write("Введите конец маршрута: ");
            var nameEndOfRoute = CheckName(Console.ReadLine(), nameof(EndOfRouteName));       // Проверка на маршрут (3)
            Console.Write("Введите номер маршрута: ");
            var numberOfRoute = CheckNumberOfRoute(Console.ReadLine());      // Проверка номера
            return new Route(nameStartOfRoute, nameEndOfRoute, numberOfRoute);  
        }
        public static Route[] GetNumberOfRoutes(int count) // Создание (1)
        {
            Route[] routes = new Route[count];

            for (int i = 0; i < routes.Length; i++)
            {
                routes[i] = RouteCreate(); // Заполнение (2)
            }
            return routes;
        }
        public static Route[] SortRoutes(Route[] routes) // Сортировка (4)
        {
            for (int i = 0; i < routes.Length; i++)
            {
                for (int j = 0; j < routes.Length; j++)
                {
                    if (routes[i].NumberOfRoute < routes[j].NumberOfRoute)
                    {
                        Route replace;
                        replace = routes[i];
                        routes[i] = routes[j];
                        routes[j] = replace;
                    }
                }
            }
            return routes;
        }
        
        private static string CheckName(string input, string fieldName = "") // Проверка на точки отправки (3)
        {

            switch (fieldName)
            {
                case nameof(StartOfRouteName):
                    for(int i = 0; i < 100; i++)
                    {
                        if (string.IsNullOrEmpty(input))
                        {
                            Console.WriteLine("Начальный маршрут не введён ");
                            Console.ReadLine();
                        }
                        else if (int.TryParse(input, out i))
                        {
                            Console.WriteLine("Название начала маршрута не может быть числом ");
                            Console.ReadLine();
                        }
                        else break;
                    }
                    break;

                case nameof(EndOfRouteName):
                    for (int i = 0; i < 100; i++)
                    {
                        if (string.IsNullOrEmpty(input))
                        {
                            Console.WriteLine("Конечный маршрут не введён ");
                            Console.ReadLine();
                        }
                        else if (int.TryParse(input, out i))
                        {
                            Console.WriteLine("Название конечного маршрута не может быть числом ");
                            Console.ReadLine();
                        }
                        else break;
                    }
                    break;
            }
            return input;
        }

        private static string CheckNumberOfRoute(string input)
        {
            int value;
            for (int i = 0; i < 100; i++)
            {
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Номер маршрута не введён не введён\nВведите номер маршрута ещё раз ");
                    Console.ReadLine();
                }
                else if (!int.TryParse(input, out int result))
                {
                    Console.WriteLine("Номер маршрута введён не верно\nВведите номер маршрута ещё раз ");
                    Console.ReadLine();
                }
                else (value = Convert.ToInt32(input));
            }
            return input;
        }
        public static Route SearchRoute(Route[] array) // Поиск маршрута
        {
            Console.WriteLine("Введите номер вашего маршрута");
            if (int.TryParse(Console.ReadLine(), out int numberOfRoute))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (numberOfRoute == array[i].NumberOfRoute)
                    {

                        Console.WriteLine(array[i]);
                    }
                    else
                    {
                        Console.WriteLine(array[i]);
                        i++;
                    }
                }
            }
            return null;
        }
        public override string ToString() // Просто вывод строк
        {
            return $"Начало марщрута: {StartOfRouteName} \nКонец маршрута: {EndOfRouteName}\nНомер маршрута: {NumberOfRoute}";
        }
    }
}
