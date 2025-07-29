using System;
using System.Threading;

namespace Mynamespace
{
    public class ThreadDemo
    {
        private static object lockObject = new object(); // Static lock object
        
        public static void Main()
        {
            Thread mainthread = Thread.CurrentThread;
            mainthread.Name = "Main Thread";
            Console.WriteLine(mainthread.Name);
            
            Thread thread1 = new Thread(Test); // Direct method reference
            Thread thread2 = new Thread(Test);
            
            thread1.Name = "Thread 1";
            thread2.Name = "Thread 2";
            
            thread1.Start();
            thread2.Start();
            
            // Wait for threads to complete
            thread1.Join();
            thread2.Join();
            
            Console.WriteLine(mainthread.Name + " IS Complete");
        }

        public static void Test()
        {
            lock (lockObject) // Lock on static object
            {
                Console.WriteLine(Thread.CurrentThread.Name + "started");
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "" +"- Timer:"+i);
                    Thread.Sleep(1000);
                }
                Console.WriteLine(Thread.CurrentThread.Name +"- Timer is complete");
            }
        }
    }
}
