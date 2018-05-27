using System;

namespace Zombie.Simulator

{
    class Program
    {
        static void Main(string[] args)
        {
// Person doesn't work any more since we override.
           /* Person p1 = new Person ();
            p1.DistanceTraveled = 10;
            p1.Walk(15);
            Console.WriteLine("The person travelled: " + p1.DistanceTraveled);
            Person p2 = new Person ();
            p2.DistanceTraveled = 15;
            p2.Walk (2);
            Console.WriteLine("The person travelled: " + p2.DistanceTraveled);
            */
            Zombie z1 = new Zombie ();
            z1.DistanceTraveled =10;
            z1.Walk(6);
            Console.WriteLine("z1 travelled: " + z1.DistanceTraveled);

            Human h1 = new Human(); 
            h1.DistanceTraveled = 10;
            h1.Run(3);
            Console.WriteLine("h1 travelled: " + h1.DistanceTraveled);

            Zombie z2 = new Zombie();
            z2.DistanceTraveled = 15;
            z2.Walk(9);
            Console.WriteLine("z2 travelled: " + z2.DistanceTraveled);

            Human h2 = new Human(); 
            h2.DistanceTraveled = 10;
            h2.Run(7);
            Console.WriteLine("h2 travelled: " + h2.DistanceTraveled);
        }
    }
}
