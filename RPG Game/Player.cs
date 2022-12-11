using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    /// <summary>
    /// This class represents the playable player.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// This represents the players health.
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// This represents the players Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Determines if player is dead.
        /// </summary>
        public bool isDead { get; set; }

        /// <summary>
        /// Determines if player is guarding.
        /// </summary>
        public bool isGuarding { get; set; }


        public Player()
        {
            //Set players health to 100.
            Health = 100;
        }

        public void GetsHit(int hit_value)
        {
            //Check if player was guarding.
            if (isGuarding)
            {
                //Write out thaht player guarded the attack.
                Console.WriteLine(Name + " was guarding and took no damage.");

                //Remove the guard.
                isGuarding = false;
            } 
            else
            {
                //Subtract the hit value from the health.
                Health = Health - hit_value;

                //Write that player got hit.
                Console.WriteLine(Name + " was hit for " + hit_value + "damage! You now have " + Health + " health remaning.");
            }

            //Check if the player is dead.
            if (Health <= 0)
            {
                //Player is dead.
                Die();
            }
        }

        public void Heal(int heal_value)
        {
            //Healing the player with an x amount of health.
            Health = (Health + heal_value > 100) ? 100 : (Health + heal_value);

            //Let player know his current Health
            Console.WriteLine(Name + " has healed " + heal_value + " health. You now have " + Health + " health remaining.");

            if (Health > 100)
            {
                Health = 100;
            }
        }

        private void Die()
        {
            //Write that the player is dead.
            Console.WriteLine(Name + " is dead!");

            //Set "isDead" true.
            isDead = true;
        }
    }
}
