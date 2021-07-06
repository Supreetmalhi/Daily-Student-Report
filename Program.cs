using System;

namespace Daily_Student_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            String Course, NeedHelp, Exp, Feedback;
            int Pgnum;
            Double Hrs;

            Console.WriteLine("What course are you in ?");
            Course = Console.ReadLine();

            Console.WriteLine("What page number ?");
            Pgnum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            NeedHelp = Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            Exp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            Feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            Hrs = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");



        }
    }
    
}
