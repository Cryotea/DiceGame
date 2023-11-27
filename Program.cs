using System.Data;
using diceGame;
using diceGame.Enemy;
using diceGame.Weapon;

class Program
{
    static void Main(string[] args)
    {
        var random = new Random();

        var loot = new Loot();

        double dice = random.Next(1,7);

        var player = new Player();

        player.Inventory.GainStartEquip();

        bool hasFainted = false; 

        Console.WriteLine("Wellcome to DiceGame \nPlease input youre Name ");
        player.Name = Console.ReadLine();

        while (!hasFainted && Fight.GetEnemyEncounters() > 0)
        {
            var enemy = Fight.GetEnemy();  

            bool gameEnd = false;

            if (hasFainted) break;

            player.Health = player.MaxHealth;

            Console.WriteLine($"\n{player.Name} encountered a {enemy.Name}");
            while (!gameEnd)
            {
                bool usedMove = false;
                while (!usedMove)
                {
                    usedMove = player.PlayerMove(player , enemy, usedMove);
                }
                
                enemy.Effect.GetBuffed(enemy);
                enemy.Effect.GetDebuffed(enemy);
                enemy.Weapon.AttackPattern(enemy, player);
           
                if (player.Health <= 0)
                {
                    gameEnd = true;
                    hasFainted = true;
                }
    
                if (enemy.Health <= 0)
                {
                    gameEnd = true;
                    Console.WriteLine($"{player.Name} defeated {enemy.Name}");
                }
            }
            enemy.GetStats(player);
            loot.GetLoot(player , enemy);
            enemy.GetExp(player);
        }

        if (hasFainted)
        {
            Console.WriteLine($"You lost! {player.Name} has died D:");
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }  
        else
        {
            Console.WriteLine($"{player.Name} won all the fights! Good job!");
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

    }
}