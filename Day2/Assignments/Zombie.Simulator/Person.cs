using System;

namespace Zombie.Simulator

{
    public abstract class Person {
        public int DistanceTraveled { get; set; }
        public Person () {
            Console.WriteLine ("New person has been created.");
        }

        public virtual void Walk (int minutes) {
            DistanceTraveled = DistanceTraveled + minutes * 2;
        }
    }
}