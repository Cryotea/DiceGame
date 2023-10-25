public class Player
{
    public double health = 20;
    public double damage = 1;
    public double speed = 1;
    public double defence = 1;
    public string weapon = "none";
}

public class Weapon
{

}

public class EnemySlime
{
    public double health = 15;
    public double damage = 0.5;
    public double speed = 1;
    public double defence = 1.2;
    public string weapon = "none";
}

class Program
{
    static void Main(string[] args)
    {
        var random = new Random();

        double dice = random.Next(1,7);

        var player = new Player();

        var slime = new EnemySlime();


        bool gameEnd = false;

        double end = 0; 

        while (!gameEnd)
        {
            Console.WriteLine("press enter to throw the dice");
            Console.ReadLine();
            dice = random.Next(1,7);
            slime.health = slime.health - dice / slime.defence;
            double dmgToEnemy = dice / slime.defence;
            Console.WriteLine($"you rolled a {dice} and attacked for {dmgToEnemy} DMG. The Enemy has {slime.health} HP left. ");

            dice = random.Next(1,7);
            player.health = player.health - dice / player.defence;
            double dmgToPlayer = dice / player.defence;
            Console.WriteLine($"the enemy rolled a {dice} and you recieved {dmgToPlayer} DMG. You have {player.health} HP left.");

        if (player.health <= 0)
        {
            gameEnd = true;
            end = 1;
        }
    
        if (slime.health <= 0)
        {
            gameEnd = true;
            
        }

        }


        if (end ==1)
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