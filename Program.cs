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

        bool hasFainted = false; 
        
        double encounters = 0;

        Console.WriteLine("Wellcome to DiceGame \nPlease input youre Name ");
        player.Name = Console.ReadLine();

        while (encounters < 4)
        {
            var enemy = Fight.GetEnemy();  

            bool gameEnd = false;

            encounters ++ ;

            player.Health = player.MaxHealth;

            Console.WriteLine($"\n{player.Name} encountered a {enemy.Name}");
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
                    Console.WriteLine($"{player.Name} defeated {enemy.Name}");
                }

            }
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