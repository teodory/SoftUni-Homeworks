using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GameEngine.Interfaces
{
    interface ITimeout
    {
        int Timeout { get; set; }
        int Countdown { get; set; }
        bool HasTimedOut { get; set; }
    }
}
