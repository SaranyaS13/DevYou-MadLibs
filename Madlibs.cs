using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Declaration of Variables and getting user input */
            Console.WriteLine("Enter any adjective...");
            String adjective1 = Console.ReadLine();
            Console.WriteLine("Enter any noun...");
            String noun1 = Console.ReadLine();
            Console.WriteLine("Enter any pastverb...");
            String pastverb1 = Console.ReadLine();
            Console.WriteLine("Enter any adverb...");
            String adverb1 = Console.ReadLine();
            Console.WriteLine("Enter any adjective...");
            String adjective2 = Console.ReadLine();
            Console.WriteLine("Enter any noun...");
            String noun2 = Console.ReadLine();
            Console.WriteLine("Enter any noun...");
            String noun3 = Console.ReadLine();
            Console.WriteLine("Enter any adjective...");
            String adjective3 = Console.ReadLine();
            Console.WriteLine("Enter any verb...");
            String verb1 = Console.ReadLine();
            Console.WriteLine("Enter any adverb...");
            String adverb2 = Console.ReadLine();
            Console.WriteLine("Enter any pastverb...");
            String pastverb2 = Console.ReadLine();
            Console.WriteLine("Enter any adjective...");
            String adjective4 = Console.ReadLine();
            /* Priniting to Console */
            Console.WriteLine("Today I went to the zoo. I saw a {0} {1} jumping up and down in its tree. He {2} {3} through \n" +
                "the large tunnel that led to its {4} {5} . I got some peanuts and passed them through the cage to a gigantic gray \n" +
                "{6} towering above my head.Feeding that animal made me hungry.I went to get a {7} scoop of ice \n"+               
                "cream.It filled my stomach.Afterwards I had to {8} {9} to catch our bus. When I got home I {10} \n" +
                "my mom for a {11} day at the zoo. ",adjective1,noun1,pastverb1, adverb1, adjective2, noun2, noun3, adjective3, verb1, adverb2, pastverb2, adjective4);

            Console.ReadLine();
        }
        }
}
