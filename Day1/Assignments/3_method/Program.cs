using System;

namespace _3_method 
{
    class Program 
    {  
         private static void GetStatus () 
        {
                    int[] status = { 1, 1, 2, 3, 2, 4 };
                    string[] names = { "John", "Kurt", "Justin", "Hanna", "Diamond", "Mia" };
                    int counter = 0;
                while (counter<status.Length){
                switch (status[counter]) 
                {
                    case 1:
                        {
                            Console.WriteLine (names[counter] + " is " + "alive" + ".");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine (names[counter] + " is " + "zombie" + ".");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine (names[counter] + " is " + "dead" + ".");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine (names[counter] + "  is " + "unkown" + ".");
                            break;
                        }

                }
                counter++;}
        }
        static void Main (string[] args) 
        {
            GetStatus ();
        }
    }
}