using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingExample
{
    class Program
    {
        int x = 0;

        static void Main(string[] args)
        {
            Program p = new Program();
            Thread t1 = new Thread(p.CountUp);
            Thread t2 = new Thread(p.CountDown);
            t1.Start();
            t2.Start();
        }

        void CountUp()
        {
            while (x < 1000)
            {
                x += 1;
                Console.WriteLine(x);
                Thread.Sleep(100);
            }
        }

        void CountDown()
        {
            while (x > -1000)
            {
                x -= 1;
                Console.WriteLine(x);
                Thread.Sleep(100);
            }
        }
    }
}
