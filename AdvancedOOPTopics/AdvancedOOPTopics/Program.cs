using System.Text.RegularExpressions;

namespace AdvancedOOPTopics
{
    enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday, 
        Saturday,
        Sunday
    }

    enum Months
    {
        Jan,
        Fab,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullables forNulls = new Nullables();
            forNulls.Run();

            /*
            ForDateTime dateTime = new ForDateTime();
            dateTime.Run();

            /*
            RegExpressions regex = new RegExpressions();
            regex.Run();

            

            
            /*
            RandomClass rnd = new RandomClass();
            rnd.Run();



            /*
            Excercise ex = new Excercise();
            ex.Run(Console.ReadLine());


            /*
            ForMathClass math = new ForMathClass();
            math.Check();

            // ENUMS 
            /*
            Months month;
            month = Months.Nov;
            Console.WriteLine(Months.Nov);
            Console.WriteLine(month);
            Console.WriteLine((int)Months.Nov);

            /*
            Day fr = Day.Friday;
            Day su = Day.Sunday;
            
            Day a = Day.Friday;
            Console.WriteLine(Day.Monday);
            Console.WriteLine(a==fr);

            /*
            Game game = new Game(); 
            Console.WriteLine(game.GetType().Name + "'s name is: {0}", game.name);
            Check check = new Check(3);
            check.DisplayInfo();
            */
        }
    }


    struct Game
    {
        //можно создавать поля 
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        // можно создавать конструкторы
        public Game()
        {
            name = "we";
            developer = "po";
            rating = 32.4;
            releaseDate = "12.12.2012";
        }


        // можно создавать методы 
        public void Display()
        {
            Console.WriteLine(GetType().Name + "'s name is: {0}", name);
        }

        // но нельзя наследовать 
        // а еще структуры находятся в стеке и к ним путь будет ближе, а следственно и быстрее в плане вычислений
    }

    class Check
    {
        public int a = 0;

        public Check(int aa)
        {
            this.a = aa;
        }

        public void DisplayInfo()
        {
            Console.WriteLine(a);
        }
    }
}