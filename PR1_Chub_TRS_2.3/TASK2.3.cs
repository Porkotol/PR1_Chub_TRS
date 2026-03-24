class Program
{
    static void Main(string[] args)
    {
        int number = 4;
        Thread myThread = new Thread(new ParameterizedThreadStart(Count)); // створення нового потоку з параметром
        myThread.Start(number); // передаємо змінну у новий потік

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Головний потiк: " + i * i);
            Thread.Sleep(300);
        }
        Console.ReadLine();
    }

    public static void Count(object x)
    {
        for (int i = 1; i <= 10; i++)
        {
            int n = (int)x; // розпаковуємо параметр
            Console.WriteLine("\tДругий потiк: " + i * n);
            Thread.Sleep(400);
        }
    }
}