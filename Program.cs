﻿using System.Data;
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

        // var enemy = new EnemySlime
        var enemy = ;
        Fight.GetEnemy(out enemy);  // ich brauch n weg denn ifighter aus der funktion zu bekommen zu erst hab ich es mit ner var probiert
                         // aber das hat mir direkt n fehle in der funtion gegeben also hab ich es mit IFighter probiert

        bool gameEnd = false;

        bool hasFainted = false; 

        while (!gameEnd)
        {
            player.Weapon.AttackPattern(player, enemy);

            enemy.Weapon.AttackPattern(enemy, player);
           
            if (player.Health <= 0)
            {
                gameEnd = true;
                hasFainted = true;
            }
    
            if (enemy.Health <= 0)
            {
                gameEnd = true;
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
            Console.WriteLine("You won the fight! Good job!");
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

    }
}