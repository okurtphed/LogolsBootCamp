using System;

namespace Day1 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Put any number");

            int status = Convert.ToInt32 (Console.ReadLine ());

            switch (status) {

                case 1:
                    Console.WriteLine ("Alive");
                    break;

                case 2:
                    Console.WriteLine ("Zombie");
                    break;
                case 3:
                    Console.WriteLine ("Dead");
                    break;
                default:
                    Console.WriteLine ("Unknown");
                    break;

            }
        }
    }
}