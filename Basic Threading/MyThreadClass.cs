﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Basic_Threading
{
    internal class MyThreadClass
    {
        public static void thread1()
        {
            for (int loopCount = 0; loopCount < 3; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Thread.Sleep(500);
                Console.WriteLine("Name of the Thread: " +thread.Name+ " = "+ loopCount);
            }
        }   
        public static void thread2()
        {
            for (int loopCount = 0; loopCount < 6; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Thread.Sleep(1500);
                Console.WriteLine("Name of the Thread: " + thread.Name + " = " + loopCount);
            }
        }
    }
}
