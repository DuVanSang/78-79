using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class bài78
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Phần a: Chạy một thread
        var thread = new Thread(() =>
        {
            Console.WriteLine("Thread bắt đầu.");
            Thread.Sleep(1000); // Dừng thread trong 1 giây
            Console.WriteLine("Thread kết thúc.");
        });

        thread.Start();
        thread.Join(); // Đợi thread hoàn thành

        // Phần b: Gọi hàm không đồng bộ
        async1().Wait(); // Gọi hàm async và đợi nó hoàn thành

        Console.WriteLine("Main thread kết thúc.");
    }

    public static async Task async1()
    {
        Console.WriteLine("Async bắt đầu.");
        await Task.Delay(1000); // Dừng async trong 1 giây
        Console.WriteLine("Async kết thúc.");
    }
}
