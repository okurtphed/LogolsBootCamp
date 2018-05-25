using System;

namespace _2._4_for_each {
    class Program {
        static void Main (string[] args) {
            int[] status = { 1, 1, 2, 3, 2, 4 };
            string[] names = { "John", "Kurt", "Justin", "Hanna", "Diamond", "Mia" };
            int counter=0;
            foreach (int  health in status) 
            {
                
                if (health == 1) {
                    Console.WriteLine (names[counter] + " is alive.");

                } else if (health == 2) {
                    Console.WriteLine (names[counter] + " is zombie.");
                    
                } else if (health == 3) {
                    Console.WriteLine (names[counter] + " is dead.");
                    
                } else {
                    Console.WriteLine (names[counter] + " is unknown");
                    
                }
                counter++;
            }
            
        } 
    }

}