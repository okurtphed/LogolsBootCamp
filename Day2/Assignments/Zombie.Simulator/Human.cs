using System;

namespace Zombie.Simulator

{
    public sealed class Human : Person {

        public void Run (int minutes) {
            DistanceTraveled = DistanceTraveled + minutes * 5;
        }
    }
}