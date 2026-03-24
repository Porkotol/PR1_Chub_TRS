class MyThread
{
    public int Count;
    public void Run(object x)
    {
        Console.WriteLine("Thread " + x + " is started.");
        do
        {
            Thread.Sleep(2 + 5 * (int)x);
            Console.WriteLine(" Thread-" + x + "-" + Count);
            Count++;
        } while (Count <= 10);
        Console.WriteLine("\nThread " + x + " is finished.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        int n = 3;
        Console.WriteLine("\t\tMain start");

        MyThread[] mt = new MyThread[n];
        for (int i = 0; i < n; i++)
        {
            mt[i] = new MyThread();
        }

        Thread[] newThrd = new Thread[n];
        for (int i = 0; i < n; i++)
        {
            newThrd[i] = new Thread(mt[i].Run);
        }

        for (int i = 0; i < n; i++)
        {
            newThrd[i].Start(i); // запуск усіх потоків
        }

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("\t\tMain ");
            Thread.Sleep(7);
        }

        for (int i = 0; i < n; i++)
        {
            newThrd[i].Join();
        }

        Console.WriteLine("\t\tMain end");
        Console.ReadKey();
    }
}