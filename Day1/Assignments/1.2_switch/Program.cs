using System;

namespace _1._2_switch {
    class Program {
        static void Main (string[] args) {
            int status = 1;

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
                case 4:
                    Console.WriteLine ("Unknown");
                    break;
            }
        }
    }
}