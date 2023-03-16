using System.Threading;
namespace ForTimers
{
    internal class Program
    {
        bool isPlaying = false;
        static int schoolHours = 10;
        static int currDuration = 0;
        static void Main(string[] args)
        {
            int num = 0;
            // устанавливаем метод обратного вызова
            TimerCallback tm = new TimerCallback(Count);
            // создаем таймер
            Timer timer = new Timer(tm, null, 0, 1000);

            Console.ReadLine();
        }
        public static void Count(object obj)
        {
            if (schoolHours > 0)
            {
                Console.Clear();
                schoolHours--;
                Console.WriteLine("video at {0}s", schoolHours);
                GC.Collect();
            }
            else
            {
                Console.WriteLine("pep");
            }
        }




    }
}