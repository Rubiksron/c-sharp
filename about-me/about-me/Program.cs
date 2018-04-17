using System;


namespace Class01Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Info i = new Info();
            Questions q1 = new Questions();
            Questions q2 = new Questions();
            Questions q3 = new Questions();
            int numCorrect = i.Question1() + i.Question2() + i.Question3();
            Console.WriteLine($"You answered { numCorrect } correctly, Well done! Thanks for playing.");
            Console.ReadKey();
        }

    }
}
