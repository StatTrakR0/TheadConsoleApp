using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads_ConsoleApp
{
    
    class Lab_01
    {
        static void Max(object ara)
        {
            int[] arr = (int[])ara;
            int Result = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if(Result < arr[i])
                {
                    Result = arr[i];
                }
            }
            Console.WriteLine("Result of first thread:{0} ",Result);
        }
        static void Avg(object ara)
        {
            int[] arr = (int[])ara;
            int Result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Result += arr[i];
            }
            Result = Result / 9;
            Console.WriteLine("Result of second thread:{0} ", Result);
        }
        static void Min(object ara)
        {
            int[] arr = (int[])ara;
            int Result = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (Result > arr[i])
                {
                    Result = arr[i];
                }
            }
            Console.WriteLine("Result of third thread:{0} ", Result);
        }
        static void Main(string[] args)
        {
            int[] arr = { 489, 123, 780, 232, 4890, 205, 309, 558, 111 };
            
            Thread t1 = new Thread(new ParameterizedThreadStart(Max));
            t1.Start(arr);
            Thread.Sleep(1000);

            Thread t2 = new Thread(new ParameterizedThreadStart(Avg));
            t2.Start(arr);
            Thread.Sleep(1000);

            Thread t3 = new Thread(new ParameterizedThreadStart(Min));
            t3.Start(arr);
            Thread.Sleep(1000);

            Console.ReadKey();
        }
        
    }
}
