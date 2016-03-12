using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Action
{

    public class AsyncTimer
    {
        //Action (a method to be called on every t milliseconds), 
        //ticks (the number of times the method should be called) and 
        //t (time interval between each tick in milliseconds).

        public event AsyncTimerEventHandler OnTick;

        private int ticks;
        private int times;

        public AsyncTimer(int ticks, int times)
        {
            this.Ticks = ticks;
            this.Times = times;
        }

        public int Ticks { get; set; }
        public int Times { get; set; }


        public void Run()
        {
            while (Times < Ticks)
            {
                if (this.OnTick != null)
                {
                    this.OnTick(this, new AsyncTimerTickArgs(this.Ticks, this.Times));
                }
            this.Times++;
            }
        }
    }
}
