using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VtitBid.ISP20.Chernetsov.Gnomes
{
    class Program
    {
        static void Main(string[] args)
        {
            Gnomes gnome = new Gnomes("Цвет шапки");
            Gnomes[] gnomes = new Gnomes[6];

            Balloons ballon = new Balloons("Цвет шарика", "Форма шарика");
            Balloons[] ballons = new Balloons[6];

            string[] allColors = { "красный", "синий", "зеленый", "желтый" };
            string[] ballonForm = { "обычный", "сердечный" };

            for(int i = 0; i < 6; i++)
            {
                Gnomes.GnomesCreator();
                Balloons.BallonsCreator();
            }
        }
    }
}