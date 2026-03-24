using System;
using System.Collections.Generic;
using System.Text;

namespace PR1_Chub_TRS
{
    public class MyThread
    {
        public int Count;
        public void Run()
        {
            Console.WriteLine("Новий потiк запущено.");
            Console.Write("Пiдрахунок: ");
            do
            {
                Thread.Sleep(500);
                Console.Write(Count + " ");
                Count++;
            } while (Count <= 10);
            Console.WriteLine("\nНовий потiк закiнчено.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyThread mt = new MyThread();
            Thread newThrd = new Thread(mt.Run); // створюється потік

            Console.WriteLine("\t Головний потiк пiдрахунок = " + mt.Count);
            newThrd.Start(); // запуск потоку

            for (int i = 20; i <= 30; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("\t Головний потiк = " + i);
            }

            newThrd.Join(); // очікування завершення  потоку
            Console.WriteLine("\t Головний потiк пiдрахунок = " + mt.Count);
            Console.ReadKey();
        }
    }
}
