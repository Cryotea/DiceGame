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

        var slime = new EnemySlime();

       // var thisFight = new Fight();

        bool gameEnd = false;

        bool hasFainted = false; 

        while (!gameEnd)
        {
            player.Weapon.AttackPattern(player, slime);

            slime.Weapon.AttackPattern(slime, player);
           
        if (player.Health <= 0)
        {
            gameEnd = true;
            hasFainted = true;
        }
    
        if (slime.Health <= 0)
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