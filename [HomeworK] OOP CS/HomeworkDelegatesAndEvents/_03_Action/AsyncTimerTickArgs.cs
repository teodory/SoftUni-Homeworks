using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Action
{
    public delegate void AsyncTimerEventHandler(AsyncTimer sender, AsyncTimerTickArgs args);

    public class AsyncTimerTickArgs
    {
        public AsyncTimerTickArgs(int ticks, int times)
        {
            this.Ticks = ticks;
            this.Times = times;
        }

        public int Ticks { get; set; }

        public int Times { get; set; }

    }
}
