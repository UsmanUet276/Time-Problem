using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    internal class Class1
    {
        public Class1() { }
        public Class1(int second, int minutes, int hours)
        {
            this.seconds = second;
            this.minutes = minutes;
            this.hours = hours;
        }

        public int seconds;
        public int minutes;
        public int hours;

        public int timeInSeconds()
        {
            int sec = 0;
            sec = (hours*3600) + (minutes * 60) + seconds;
            return sec;
        }
    }
}
