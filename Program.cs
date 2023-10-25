public class Player
{
    public double health {get; set;} = 20;
    public double damage {get; set;} = 1;
    public double speed {get; set;} = 1;
    public double defence {get; set;} = 1;
    public string weapon {get; set;} = "noWeapon";
}

public class Weapon
{
    public double[] noWeapon = new double[4];

    public Weapon()
    {
        noWeapon[0] = 0;
        noWeapon[1] = 0;
        noWeapon[2] = 0;
        noWeapon[3] = 0;
    }
}

public class EnemySlime
{
    public double health {get; set;} = 15;
    public double damage {get; set;} = 0.5;
    public double speed {get; set;} = 1;
    public double defence {get; set;} = 1.2;
    public string weapon {get; set;} = "noWeapon";
}

public class Fight
{
    public void PlayerAtack( out double newEnemyHealth, double dice, double enemyhealth, double enemydefence, double playerdamage)
    {
        Console.WriteLine("press enter to throw the dice");
        Console.ReadLine();
        enemyhealth = enemyhealth - dice * playerdamage / enemydefence;
        double dmgToEnemy = dice * playerdamage / enemydefence;
        Console.WriteLine($"you rolled a {dice} and attacked for {dmgToEnemy} DMG. The Enemy has {enemyhealth} HP left. ");
        newEnemyHealth = enemyhealth;
    }


    public void EnemyAtack(out double newPlayerHealth, double dice, double playerhealth, double playerdefence, double enemydamage)
    {
        playerhealth = playerhealth - dice * enemydamage / playerdefence;
        double dmgToPlayer = dice * enemydamage / playerdefence;
        Console.WriteLine($"The enemy rollad a {dice} and attacked you for {dmgToPlayer} DMG. you have {playerhealth} HP left. ");
        newPlayerHealth = playerhealth;  
    }
}

class Program
{
    static void Main(string[] args)
    {
        var random = new Random();

        double dice = random.Next(1,7);

        var player = new Player();

        var slime = new EnemySlime();

        var thisfight = new Fight();

        bool gameEnd = false;

        double end = 0; 

        while (!gameEnd)
        {
            double newEnemyHealth = 0;
            double newPlayerHealth = 0;
            thisfight.PlayerAtack( out newEnemyHealth, random.Next(1,7) , slime.health, slime.defence, player.damage);  

            slime.health = newEnemyHealth;

            thisfight.EnemyAtack (out newPlayerHealth, random.Next(1,7), player.health, player.defence, slime.damage);

            player.health = newPlayerHealth;

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