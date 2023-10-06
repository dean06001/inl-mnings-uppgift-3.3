using System;
namespace inlämnings_uppgift_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej ur länge vill du hyra ett fordon?");
            int timmar = int.Parse(Console.ReadLine());
            if (timmar * 80 > 950)
            {
                Console.WriteLine("Det kommer att kosta 950");
            }
            else
            {
                int hyra = timmar * 80;
                Console.WriteLine("Det kommer att kosta dig " + hyra + "kr.");
            }
            Console.ReadKey();
        }
    }
}