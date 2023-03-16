using System.IO;
namespace ReadAndWriteFromATextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // method 1 
            string[] lines = { "First250", "Second242", "Third251", "Forth240" };
            int[] scores = { 250, 242, 249 };
            File.WriteAllLines(@"C:\Users\Amachuarori\Documents\scores.txt", lines);

            

            // method 3
            using(StreamWriter file = new StreamWriter(@"C:\Users\Amachuarori\Documents\MyText2.txt"))
            {
                foreach(var line in lines)
                {
                    if (line.Contains("2"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(@"C:\Users\Amachuarori\Documents\MyText2.txt", true))
            {
                file.WriteLine("Aditional line");
            }

            // method 2
            Console.WriteLine("give a file name");
            string fileName = Console.ReadLine();
            Console.WriteLine("enter the text for the file");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Amachuarori\Documents\" + fileName + ".txt", input);

            /*
            //Example 1;
            string text = File.ReadAllText(@"C:\Users\Amachuarori\Documents\forCourse.txt");
            Console.WriteLine("text file contains following text: \n" + text);


            //Example 2
            string[] lines = File.ReadAllLines(@"C:\Users\Amachuarori\Documents\forCourse.txt");

            Console.WriteLine("file txt contains:");

            foreach(var e in lines)
            {
                Console.WriteLine(e);
                Console.WriteLine(1);
            } */
        }
    }
}