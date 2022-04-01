using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.BL;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int remainingTime = 0;
            Class1 time1 = new Class1();
            Class1 time = new Class1(9, 11, 11);
            int sec = time.timeInSeconds();
            time1 = inputTime();
            int sec1 = time1.timeInSeconds();
            remainingTime = sec1 - sec;
            Console.WriteLine(remainingTime);
        }
        static Class1 inputTime() 
        { 
        
            Class1 temp = new Class1();
            Console.Write("Hour : ");
            temp.hours = int.Parse(Console.ReadLine());
            Console.Write("Minutes : ");
            temp.minutes = int.Parse(Console.ReadLine());
            Console.Write("Seconds : ");
            temp.seconds = int.Parse(Console.ReadLine());
            return temp;
        }
    }
}
