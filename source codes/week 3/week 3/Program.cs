using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch myStop = new Stopwatch();

            myStop.Start();
            bigOn2(10000);
            myStop.Stop();
            Console.WriteLine("bigOn2 run time " + myStop.ElapsedMilliseconds + " ms");

            myStop.Reset();

            myStop.Start();
            bigO2n(24);
            myStop.Stop();
            Console.WriteLine("bigO2n run time " + myStop.ElapsedMilliseconds + " ms");

            Console.ReadLine();

        }

        static void bigOn2(decimal n)
        {
            //n bagimli,
            decimal nCopy = n;//1
            for (decimal i = 0; i < n; i++)//n
            {
                while (nCopy > 0)//n
                {
                    nCopy--;//1
                    string denem = "";//1
                    denem = (3 + 6).ToString();//1
                }
            }

            //n*n*3 = 3n^2

            for (decimal i = 0; i < n; i++)
            {
                string denem = "";
                denem = "3 + 6";
            }
            //2n

            //f(n) = 3n^2+2n
            //f(n) = O(?)
            //f(n) = O(n^2)
        }

        static void bigO2n(double n)
        {
            double total = 0;//1
            for (double i = 0; i < Math.Pow(2,n); i++)//2^n
            {
                double cc = i * n;//1
                total += cc;//1
            }

            //2*2^n+1

            for (double mm = 0; mm < n; mm++)//n
            {
                for (double nn = 0; nn < n; nn++)//n
                {
                    for (double gg = 0; gg < n; gg++)//n
                    {
                        double cc = gg * n;//1
                        total += cc;//1
                    }
                }
            }

            //n*n*n*2=2n^3

            //f(n)=2*2^n + 1 + 2n^3
            //f(n) = O(2^n)
        }
    }
}
