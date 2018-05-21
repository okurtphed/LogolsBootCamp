using System;

namespace Day1 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Put any number");

            int num = Convert.ToInt32 (Console.ReadLine ());

            if (num < 20) {
                Console.WriteLine ("small");
            } else {
                Console.WriteLine ("big");
            }

            // not working! for switch
            /*
                
            if conditions are
            ok with ><
             */

        }
    }
}