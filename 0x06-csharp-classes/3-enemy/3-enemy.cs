﻿using System;

namespace Enemies
{
    /// <summary>
    /// This is our class Zombie.
    /// </summary>
    class Zombie
    {
        private int health;
        public Zombie()
        {
            health = 0;
        }
        public Zombie(int value)
        {
            if (value >= 0)
                this.health = value;
            else if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
        }
    }
}
