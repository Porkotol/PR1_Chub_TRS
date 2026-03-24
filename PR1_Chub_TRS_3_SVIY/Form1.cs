namespace PR1_Chub_TRS_3_SVIY
{
    public partial class Chub_PR1_TRS : Form
    {
        private Thread thread1; //  1 птк числа по порядку
        private Thread thread2; //  2 птк числа Фібоначчі
        private Thread thread3; //  3 птк прямокутники
        private Random rnd = new Random();
        public Chub_PR1_TRS()
        {
            InitializeComponent();
        }


        private void GenerateSequence() 
        {
            int count = 0; 
            while (true) 
            {
                AddToListBox(listBox1, count.ToString()); 
                count++; 
                Thread.Sleep(500); // 0.5 секунд
            }
        }

        private void GenerateFibonacci() 
        {
            int a = 0; // перше число посл
            int b = 1; // друге число посл

            AddToListBox(listBox2, a.ToString()); 

            while (true) 
            {
                AddToListBox(listBox2, b.ToString()); 
                int temp = a; // попередне числ
                a = b;  
                b = temp + a; // обчислення фібоначі
                Thread.Sleep(500); 
            }
        }

        private void AddToListBox(ListBox lb, string text) => lb.Invoke(new Action(() => lb.Items.Add(text)));
        private void DrawRectangles() //відрисовка
        {
            while (true) 
            {
                DrawRectangle(); 
                Thread.Sleep(300); 
            }
        }


        private void DrawRectangle() 
        {
            if (panel1.InvokeRequired) 
            {
                panel1.Invoke(new Action(DrawRandomRect)); //в головний потік
            }
            else
            {
                DrawRandomRect(); 
            }
        }

        private void DrawRandomRect() 
        {
            using (Graphics g = panel1.CreateGraphics()) // Graphics панелі
            {
                int width = rnd.Next(10, 60); 
                int height = rnd.Next(10, 60);

                int x = rnd.Next(0, Math.Max(1, panel1.Width - width));
                int y = rnd.Next(0, Math.Max(1, panel1.Height - height)); //перевірка , щоб прямокутник не виходив за межі панелі

                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                using (SolidBrush brush = new SolidBrush(randomColor)) // колір
                {
                    g.FillRectangle(brush, x, y, width, height);
                }
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            thread1 = new Thread(GenerateSequence); 
            thread1.Start(); 

            thread2 = new Thread(GenerateFibonacci);
            thread2.Start();

            thread3 = new Thread(DrawRectangles);
            thread3.Start();
        }
    }
}
