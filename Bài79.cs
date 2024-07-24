using System;
using System.Text;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Tạo và chạy thread thực hiện hàm DoWork
        var workerThread = new Thread(DoWork);
        workerThread.Start();
        workerThread.Join(); // Đợi thread hoàn thành

        Console.WriteLine("Main thread kết thúc.");
    }

    static void DoWork()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Worker thread: " + i);
            Thread.Sleep(100); // Dừng thread trong 100ms
        }
    }
}
