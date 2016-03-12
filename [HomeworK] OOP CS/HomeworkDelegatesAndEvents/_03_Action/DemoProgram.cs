using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Action
{
    class DemoProgram
    {
        static void Main(string[] args)
        {
            AsyncTimer timer = new AsyncTimer(5, 1);
            timer.OnTick += timer_OnTick;
            timer.Run();
            Console.WriteLine("55555");
        }

        static void timer_OnTick(AsyncTimer sender, AsyncTimerTickArgs args)
        {
            Console.WriteLine("sdasdda");
        }
    }
}
