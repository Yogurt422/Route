using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.ChernetsovKuriev.Route
{
    public class Route
    {
        public string StartOfRouteName { get; set; }
        public string EndOfRouteName { get; set; }
        public string NumberOfRoute { get; set; }

        public Route(string startOfRouteName, string endOfRouteName, string numberOfRoute)
        {
            StartOfRouteName = startOfRouteName;
            EndOfRouteName = endOfRouteName;
            NumberOfRoute = numberOfRoute;
        }
        public static string AlphabetRU =
            "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public static string AlphabetEU =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static Route RouteCreate() // Заполнение (2)
        {
            Console.Write("Введите начало маршрута: ");
            string nameStartOfRoute = CheckName(Console.ReadLine(), nameof(StartOfRouteName));   // Проверка на маршрут (3)
            Console.Write("Введите конец маршрута: ");
            string nameEndOfRoute = CheckName(Console.ReadLine(), nameof(EndOfRouteName));       // Проверка на маршрут (3)
            Console.Write("Введите номер маршрута: ");
            string numberOfRoute = CheckNumberOfRoute(Console.ReadLine());      // Проверка номера
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
        //public static Route[] SortRoutes(Route[] routes) // Сортировка (4)
        //{
        //    for (int i = 0; i < routes.Length; i++)
        //    {
        //        for (int j = 0; j < routes.Length; j++)
        //        {
        //            if (routes[i].NumberOfRoute < routes[j].NumberOfRoute)
        //            {
        //                Route replace;
        //                replace = routes[i];
        //                routes[i] = routes[j];
        //                routes[j] = replace;
        //            }
        //        }
        //    }
        //    return routes;
        //}

        private static string CheckName(string input, string fieldName = "") // Проверка на точки отправки (3)
        {

            switch (fieldName)
            {
                case nameof(StartOfRouteName):
                    for (int i = 0; i < 100; i++)
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
            input = input.ToUpper();
            for (int i = 0; i < 100; i++)
            {
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Номер маршрута не введён не введён\nВведите номер маршрута ещё раз ");
                    Console.ReadLine();
                }
                else
                {
                    int countOfchar = 0;
                    int charStartOrEnd = 0;
                    for (int j = 0; j < input.Length; j++)
                    {
                        char check = input[j];
                        for (int ru = 0; ru < AlphabetRU.Length; ru++)
                        {
                            if (check == AlphabetRU.IndexOf(AlphabetRU[ru]))
                            {
                                if (j == 0 || j == (input.Length - 1))
                                {
                                    charStartOrEnd++;
                                    countOfchar++;
                                    break;
                                }
                                else
                                {
                                    countOfchar++;
                                    break;
                                } 
                            }
                            else
                            {
                                for (int eu = 0; eu < AlphabetEU.Length; eu++)
                                {
                                    if (check == AlphabetEU.IndexOf(AlphabetEU[eu]))
                                    {
                                        if (j == 0 || j == (input.Length - 1))
                                        {
                                            charStartOrEnd++;
                                            countOfchar++;
                                            break;
                                        }
                                        else
                                        {
                                            countOfchar++;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (countOfchar == 0 || (countOfchar == 1 && charStartOrEnd == 1))
                    {
                        break;
                    }
                    else Console.WriteLine("Номер маршрута введён не правильно\nВведите номер маршрута ещё раз ");
                }
                
            }
            return input;
        }
        public static Route SearchRoute(Route[] array) // Поиск маршрута
        {
            Console.WriteLine("Введите номер вашего маршрута");
            // Дописать цикл на проверку поиска и добавить сюда (a = console.Readline)
                for (int i = 0; i < array.Length; i++)
                {
                    if (a == array[i].NumberOfRoute)
                    {

                        Console.WriteLine(array[i]);
                    }
                    else
                    {
                        Console.WriteLine(array[i]);
                        i++;
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