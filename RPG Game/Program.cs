namespace RPG_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create and store random class
            Random random = new Random();

            //Create player.
            Player player = new Player();

            //Output the text stating that we want the players name.
            Console.WriteLine("What is your name warrior?");

            //Store the players name.
            player.Name = Console.ReadLine();

            //Welcome the player.
            Console.WriteLine("Hello " + player.Name + " nice to meet you!\n");

            //Track first enemy.
            Enemy firstEnemy = new Enemy("Decepticon");

            //Perform the game loop.
            GameLoop(firstEnemy, random, player, 15, 20);

            //Check if player died.
            if (!player.isDead)
            {
                //Create boss enemy.
                Boss boss = new Boss();

                //Perform the game loop.
                GameLoop(boss, random, player, 50, 35);

                //Check if the player was the one who died.
                if (!player.isDead)
                {
                    //Player won the game.
                    Console.WriteLine("\n\nCongradulations " + player.Name + " you defeated all the enemies and saved the kingdom!!!");
                    Console.WriteLine("\n\nCongradulations " + player.Name + " you defeated all the enemies and saved the kingdom!!!\n\n\n");
                }
                else
                {
                    //The game is over.
                    GameOver();
                }
            }
            else
            {
                //The game is over.
                GameOver();
            }
        }

        private static void GameOver()
        {
            //Player is dead. Game is over.
            Console.WriteLine("GAME OVER!!!");
        }

        private static void GameLoop(Enemy enemy, Random random, Player player, int max_attack_power, int max_player_attack_power)
        {
            //Enemy attack.
            Console.WriteLine(player.Name + " you have ancountered a " + enemy.Name + "!");

            //While first enemy and player are not dead, repeat the playable cycle.
            while (!enemy.isDead && !player.isDead)
            {
                //Attacking options
                Console.WriteLine("What would you like to do? \n\n1.Single attack \n2.Double attack \n3.Defend \n4.Heal");

                //Store choosen action.
                string playersAction = Console.ReadLine();

                //Check choosen action.
                switch (playersAction)
                {
                    case "1":
                        //Write out that player choose 1.
                        Console.WriteLine("You choose to single attack the " + enemy.Name + "!");

                        //Apply attack damage to enemy.
                        enemy.GetsHit(random.Next(10, max_player_attack_power));

                        break;
                    case "2":
                        //Write out that player choose 2.
                        Console.WriteLine("You choose to double attack the " + enemy.Name + " !");

                        //Loop two times to perform the double attack.
                        for (int i = 0; i < 2; i++)
                        {
                            //Apply attack damage to enemy.
                            enemy.GetsHit(random.Next(10, max_attack_power));

                            //Check if enemy is dead.
                            if (enemy.isDead)
                            {
                                //Break out of for loop.
                                break;
                            }
                        }

                        break;
                    case "3":
                        //Write out that player choose 3.
                        Console.WriteLine("You choose to defend!");

                        //Set that player is guarding
                        player.isGuarding = true;

                        break;
                    case "4":
                        //Write out that player choose 4.
                        Console.WriteLine("You choose to heal!");

                        //Heal the player a random amount.
                        player.Heal(random.Next(30, 30));

                        break;
                    default:
                        Console.WriteLine("You choose an undefined action.");

                        break;
                }

                //Make sure enemy is not dead
                if (!enemy.isDead)
                {
                    //Enemy attack player.
                    player.GetsHit(random.Next(10, max_attack_power));
                }
            }
        }
    }
}