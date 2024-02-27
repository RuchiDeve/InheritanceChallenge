
namespace InheritanceChallenge
{
    class Program
    {
        static void Main(String[] args)
        {
            Employee Israel = new Employee("Israel", "David", 8000);
            Israel.Work();
            Israel.Pause();



            Boss UruchiOkezie = new Boss("Ferrari", "Okezie", "Uruchi", 50000);
            UruchiOkezie.Lead();

            Trainee Gift = new Trainee(32, 8, "Gift", "John", 10000);
            Gift.Work();
            Gift.Learn();
            Console.ReadKey();

        }
    }
}


