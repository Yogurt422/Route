using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VtitBid.ISP20.Chernetsov.Gnomes
{
    public class Gnomes
    {
        public string HatColor { get; set; }

        public Gnomes(string hatColor)
        {
            HatColor = hatColor;
        }
        public static Gnomes GnomesCreator()
        {
            Console.WriteLine("Введите ");
            return null;
        }
    }
    public class Balloons
    {
        public string BalloonColor { get; set; }
        public string BalloonForm { get; set; }
        public Balloons (string ballonColor, string balloonFrom)
        {
            BalloonColor = ballonColor;
            BalloonForm = balloonFrom;
        }
        public static Balloons BallonsCreator()
        {
            Console.WriteLine("Введите ");
            return null;
        }
    }
    public class GnomesWithBallons : Gnomes

    {
        public string BalloonColor { get; set; }
        public string BalloonForm { get; set; }

        public GnomesWithBallons(string hatColor, string ballonColor, string balloonFrom) 
            : base(hatColor)
        {
            HatColor = hatColor;
            BalloonColor = ballonColor;
            BalloonForm = balloonFrom;
        }
    }
}
