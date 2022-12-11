using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    /// <summary>
    /// This class represents the boss enemy in the game.
    /// </summary>
    internal class Boss : Enemy
    {
        public Boss() : base("Megatron")
        {
            //Set boss health to a higher value.
            Health = 150;
        }
    }
}
