﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sin_EventNumCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CatchClass Ctc = new CatchClass();
            Ctc.NumCatch += new CatchClass.OnEventHandler(Catch1);

            for (int i = 1; i < 10; ++i)
            {
                if(i % 2 == 0 && i < 5)
                {
                    Ctc.GoEvent();
                }
                if(i == 5)
                {
                    Ctc.NumCatch -= new CatchClass.OnEventHandler(Catch1);
                    Ctc.NumCatch += new CatchClass.OnEventHandler(Catch2);
                }
                if(i % 3 == 0 && i > 5) 
                {
                    Ctc.GoEvent();
                }
                Console.WriteLine("{0}", i);
            }
        }

        static void Catch1(object sender, EventArgs e)
        {
            Console.Write("짝수 : ");
        }

        static void Catch2(object sender, EventArgs e)
        {
            Console.Write("3의 배수 : ");
        }
    }

    class CatchClass
    {
        public delegate void OnEventHandler(object sender, EventArgs e);
        public event OnEventHandler NumCatch;
        public void GoEvent()
        {
            if(NumCatch != null)
            {
                EventArgs e = new EventArgs();
                NumCatch(this, e);
            }
        }
    }
}
