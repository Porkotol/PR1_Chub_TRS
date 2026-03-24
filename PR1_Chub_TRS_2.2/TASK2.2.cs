class Program
{
    static void Main(string[] args)
    {
        Thread newThrd = Thread.CurrentThread;
        Console.WriteLine(newThrd.ThreadState);

        newThrd.IsBackground = true; // робимо потік фоновим
        Console.WriteLine(newThrd.ThreadState);

        newThrd.IsBackground = false; // робимо потік пріоритетним
        Console.WriteLine(newThrd.ThreadState);

        Console.ReadKey();
    }
}