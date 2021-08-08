using System;
using System.Collections.Generic;
namespace tur
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
             n=int.Parse(Console.ReadLine());
             SortedList<int,int > summa = new SortedList<int, int >();
            SortedList<int, SortedList<int, int>>  summa3 = new SortedList<int, SortedList<int, int>>();
            SortedList<int, int[]> summa4 = new SortedList<int, int[]>();
          // int [] summa2 = new int[2];
            int summ = 0;
            int summ2 = 0;
          //  int[] cost = new int[n];
          //  int [] day=new int [n];
            int day = 0;
            int cost = 0;
            for (int i=0;i<n;i++)
            {
               int[] summa2 = new int[2];
                // day[i]= int.Parse(Console.ReadLine());
                // cost[i] = int.Parse(Console.ReadLine());  

                day = int.Parse(Console.ReadLine());
               cost = int.Parse(Console.ReadLine());
                summa2[0] = day;
                summa2[1]=cost;
                summa4.Add(day * cost, summa2);
                summa.Add(day,cost);
                summa3.Add(day*cost, summa);
              
            }
            Console.WriteLine();
            foreach (int i in summa4.Keys)
            { 
                Console.WriteLine(i); 
            }
            Console.ReadKey();
            
        }
    }
}
