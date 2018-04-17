using System;
using System.Collections.Generic;
using System.Text;

namespace Class01Demo
{
    class Info
    {
        Responses res = new Responses();
        Questions quest = new Questions();
        public int Question1()
        {
            Console.WriteLine(quest.UserQuestion1());
            string userName = Console.ReadLine();
            if (string.IsNullOrEmpty(userName.Trim()))
            {
                Console.WriteLine(res.Response5());
                Question1();
                return 0;
            }
            else
            {
                Console.WriteLine($"Welcome { userName }, you've got your name right, that's one point! Asnswer this next question correctly or be fed to the lions!");
                Console.ReadKey();
            }
            return 1;
        }


        public int Question2()
        {
            Console.WriteLine(quest.UserQuestion2());
            string[] fishArray = new String[] { "clownfish", "goldfish", "salmon", "pureedfish" };

            foreach (string fish in fishArray)
            {
                Console.WriteLine(fish);
            }

            string fishGuess = Console.ReadLine().ToLower();

            if (fishGuess == "pureedfish")
            {

                Console.WriteLine(res.Response1());
                return 1;
            }
            else
            {
                Console.WriteLine(res.Response2());
            }
            return 0;
        }

        public int Question3()
        {
            Console.WriteLine(quest.UserQuestion3());
            string answer1 = Console.ReadLine().ToLower();
            if (answer1 == "yes" || answer1 == "y")
            {
                Console.WriteLine(res.Response3());
                Console.ReadKey();
                return 1;
            }
            else
            {
                Console.WriteLine(res.Response4());
                Console.ReadKey();
                return 0;
            }
        }
    }
}
