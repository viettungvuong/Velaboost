using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Velaboost
{
    internal class Program
    {
        static int count = 0;
        static void openVela()
        {
            var data = new WebClient().DownloadString("https://vela-academy.com/");
            count++;
            Console.WriteLine("vela-academy.com opened. Times: "+count.ToString());
        }
        static void Main()
        {
            openVela();
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromMinutes(0.5);

            var timer = new System.Threading.Timer((e) =>
            {
                openVela();
            }, null, startTimeSpan, periodTimeSpan);
            Console.ReadKey();
        }
    }
}
