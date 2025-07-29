using System;
using System.Threading;

namespace Mynamespace
{
    public class ThreadDemo
    {
        public static void Main()
        {
            Thread  mainthread = Thread.CurrentThread;
            mainthread.Name = "Main Thread";
            Console.WriteLine(mainthread.Name);

            Thread thread1 = new Thread(CountDown);
            Thread thread2 = new Thread(CountUp);
            thread1.Start();
            thread2.Start();
            //CountDown();
            //CountUp();
            Console.WriteLine(mainthread.Name + "IS Complete");
        }

        public static void CountDown()
        {
            for(int i=10;i>=0;i--)
            {
                Console.WriteLine("Timer1:"+i+" Seconds.");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer1 is complete");
        }
        public static void CountUp()
        {
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine("Timer2:"+i+" Seconds.");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer2 is complete");
        }

    }
}