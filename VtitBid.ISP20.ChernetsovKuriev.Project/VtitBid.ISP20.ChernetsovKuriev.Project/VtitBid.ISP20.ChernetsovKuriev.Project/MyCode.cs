//class Program1
//{
//    static void Main(string[] item)
//    {
//        Route route = new Route("", "", 22);
//        Route[] routes = new Route[3];
//        for (int i = 0; i < routes.Length; i++)
//        {
//            routes[i] = new Route();
//            Console.WriteLine($"Введите:\nНомер маршрута #{i + 1}\nНазвание начального пункта #{i + 1}\nНазвание конечного пункта #{i + 1}");
//            routes[i].NumberRoute = Convert.ToInt32(Console.ReadLine());
//            routes[i].StartRoute = Console.ReadLine();
//            routes[i].EndRoute = Console.ReadLine();
//        }
//        Console.WriteLine("Маршруты:");
//        for (int i = 0; i < routes.Length; i++)
//        {
//            for (int j = 0; j < routes.Length; j++)
//            {
//                if (routes[i].NumberRoute < routes[j].NumberRoute)
//                {
//                    Route a;
//                    a = routes[i];
//                    routes[i] = routes[j];
//                    routes[j] = a;
//                }
//            }
//        }
//        Console.WriteLine("Номер маршрута  Название начального пункта  Название конечного пункта");
//        for (int i = 0; i < 3; i++)
//        {
//            Console.WriteLine($"   {routes[i].NumberRoute}             {routes[i].StartRoute}                         {routes[i].EndRoute}   ");
//        }
//        Console.WriteLine();
//        Console.WriteLine("Введите номер маршрута, информацию о котором хотите узнать");
//        int d = 0;
//        for (int i = 0; i < 10; i++)
//        {
//            int a = 0;
//            int result;
//            if (int.TryParse(Console.ReadLine(), out result))
//            {
//                a = result;
//            }
//            else if (a == null)
//            {
//                Console.WriteLine("Строка пустая, введите номер маршрута ещё раз");
//            }
//            if (d == 1 && a == 1)
//            {
//                break;
//            }
//            else
//            {
//                for (int j = 0; j < 3; j++)
//                {
//                    if (Convert.ToInt32(a) == routes[j].NumberRoute)
//                    {
//                        Console.WriteLine($"{routes[j].NumberRoute}             {routes[j].StartRoute}                   {routes[j].EndRoute}");
//                        break;
//                    }
//                    else if (j == 2)
//                    {
//                        Console.WriteLine("Такого маршрута не существует");
//                    }
//                }
//            }
//            d = 1;
//            Console.WriteLine("Введите номер следующего маршрута или, если хотите прекратить, введите 1");
//        }
//    }
//}