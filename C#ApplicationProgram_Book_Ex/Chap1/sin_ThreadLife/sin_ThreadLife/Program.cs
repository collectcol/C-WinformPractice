﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sin_ThreadLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread LifeThread = new Thread(DoStop);
            LifeThread.Start();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("주(기본) 스레드 카운터 : {0}", i);
                Thread.Sleep(5);
            }
            LifeThread.Join();
            Console.WriteLine("스레드가 종료됩니다.");
        }

        private static void DoStop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("외부 스레드 카운터 : {0}", i);
                Thread.Sleep(5);
            }
        }
    }
}
