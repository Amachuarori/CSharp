using System.IO;
namespace Parsing_game_part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> a = new List<string>();
            string[] lines = File.ReadAllLines(@"C:\Users\Amachuarori\Downloads\input.txt");
            foreach (var e in lines)
            {
                if (e.Contains("split"))
                {
                    string[] split1 = e.Split("split");
                    string split2 = split1[1];
                    using (StreamWriter file = new StreamWriter(@"C:\Users\Amachuarori\Documents\output.txt", true))
                    {
                        a.Add(split2);
                    }
                }
            }
            
            foreach(var e in a)
            {
                Console.WriteLine(e[4]);
            }
        }
    }
}