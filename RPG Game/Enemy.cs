using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    /// <summary>
    /// This class represents the enemy.
    /// </summary>
    internal class Enemy
    {
        /// <summary>
        /// This represents the enemies health.
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// This represents the enemies name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Determines if enemy is dead.
        /// </summary>
        public bool isDead { get; set; }

        public Enemy(string name)
        {
            //Set enemies health to 100.
            Health = 100;

            //Set the enemy name.
            Name = name;
        }

        public void GetsHit(int hit_value)
        {
            //Subtract the hit value from the health.
            Health = Health - hit_value;

            //Write that enemy got hit.
            Console.WriteLine(Name + " was hit for " + hit_value + "damage! He now has " + Health + "remaning.");

            //Check if the enemy is dead.
            if (Health <= 0)
            {
                //Enemy is dead.
                Die();
            }
        }

        private void Die()
        {
            //Write that the enemy is dead.
            Console.WriteLine(Name + " was killed!");

            //Set "isDead" true.
            isDead = true;
        }
    }
}
