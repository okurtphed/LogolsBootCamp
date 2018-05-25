using System;

namespace _2._3_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] status = { 1, 1, 2, 3, 2, 4 };
            string[] names = { "John", "Kurt", "Justin", "Hanna", "Diamond", "Mia" };
            for (int counter=0; counter<status.Length; counter++)
            {
                switch (status[counter]) {
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
            }
        }
    }
}
