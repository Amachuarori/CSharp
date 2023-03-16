namespace InheritanceChallenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Alice", "Jhonson", 150000);
            Boss boss = new Boss("Peter", "QWIR", 200000, "Corvette");
            Interns intern = new Interns("Bob", "Harbour", 50000, 10);
            emp.Work();
            boss.Lead();
            boss.Work();
            intern.Work();
            
            Console.WriteLine(intern.WorkingHours); 
        }
    }
}