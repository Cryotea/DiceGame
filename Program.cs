﻿using System.Data;
using diceGame;
using diceGame.Enemy;
using diceGame.Weapon;
using Spectre.Console;

class Program
{
    static void Main(string[] args)
    {
        var log = new Log();
        var random = new Random();

        var loot = new Loot();

        double dice = random.Next(1,7);

        var player = new Player();

        player.Inventory.GainStartEquip();

        bool hasFainted = false; 

        player.Name = AnsiConsole.Ask<string>($"Welcome to DiceLike Whats your {ColorManager.PlayerColor}name[/]?");
        log.AddMessage($"Welcome to DiceLike Whats your {ColorManager.PlayerColor}name[/]? {player.Name}");
        
        while (!hasFainted && Fight.GetEnemyEncounters() > 0)
        {
            var enemy = Fight.GetEnemy();  

            bool gameEnd = false;

            if (hasFainted) break;

            player.Health.Current = player.Health.Max;

            log.AddMessage(($"\n{player.Name} encountered a {enemy.Name} ")); 
            log.WriteLatestMessage();
            while (!gameEnd)
            {
                bool usedMove = false;
                while (!usedMove)
                {
                    usedMove = player.PlayerMove(player , enemy, usedMove, log);
                }
                
                enemy.Effect.GetBuffed(enemy);
                enemy.Effect.GetDebuffed(enemy);
                log.AddMessage(enemy.Weapon.AttackPattern(enemy, player)); 
                
                log.WriteTwoLatestMessage();
           
                if (player.Health.Current <= 0)
                {
                    gameEnd = true;
                    hasFainted = true;
                }
    
                if (enemy.Health.Current <= 0)
                {
                    gameEnd = true;
                    AnsiConsole.MarkupLine($"\n{player.Name}defeated {enemy.Name}");
                }
            }
            loot.GetLoot(player , enemy);
        }

        if (hasFainted)
        {
            AnsiConsole.MarkupLine($"\nYou [red]lost[/]! {player.Name} has [red]died[/] D:");
            AnsiConsole.MarkupLine("Press enter to exit");
            Console.ReadLine();
        }  
        else
        {
            AnsiConsole.MarkupLine($"{player.Name} won all the fights! Good job!");
            AnsiConsole.MarkupLine("Press enter to exit");
            Console.ReadLine();
        }

    }
}