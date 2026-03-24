
class MyThread
{
    public int Count;
    public void Run()
    {
        Console.WriteLine("Метод Run() запущено (послiдовно).");
        Console.Write("Пiдрахунок: ");
        do
        {
            Thread.Sleep(500);
            Console.Write(Count + " ");
            Count++;
        } while (Count <= 10);
        Console.WriteLine("\nМетод Run() закiнчено.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyThread mt = new MyThread();

        mt.Run(); // посл виклик методу без потоку

        Console.WriteLine($"\n\t Головний потiк пiдрахунок = {mt.Count}");

        for (int i = 20; i <= 30; i++) //цикл післе mt.run
        {
            Thread.Sleep(500);
            Console.WriteLine($"\t Головний потiк = {i}");
        }

        Console.WriteLine($"\t Головний потiк пiдрахунок = {mt.Count}");
        Console.ReadKey();
    }
}