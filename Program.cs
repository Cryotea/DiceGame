using System.Data;
using diceGame;
using diceGame.Enemy;
using diceGame.Weapon;

class Program
{
    static void Main(string[] args)
    {
        var random = new Random();

        double dice = random.Next(1,7);

        var player = new Player();

        bool hasFainted = false; 

        double encounters = 0;

            while (encounters < 4)
            {
                var enemy = Fight.GetEnemy();  

                bool gameEnd = false;

                encounters ++ ;

                player.Health = player.MaxHealth;

                enemy.Health = enemy.MaxHealth;

                while (!gameEnd)
                {
                    player.Weapon.AttackPattern(player, enemy);

                    enemy.Weapon.AttackPattern(enemy, player);
           
                if (player.Health <= 0)
                {
                    gameEnd = true;
                    hasFainted = true;
                    encounters = 4;
                }
    
                if (enemy.Health <= 0)
                {
                    gameEnd = true;
                    Console.WriteLine($"you defeated {enemy.Name}");
                }

            }
        }

        if (hasFainted)
        {
            Console.WriteLine("You lost! The enemy has killed you D:");
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }  
        else
        {
            Console.WriteLine("You won all the fights! Good job!");
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

    }
}