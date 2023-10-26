public class Player
{
    public double Health {get; set;} = 20;
    public double Damage {get; set;} = 1;
    public double Speed {get; set;} = 1;
    public double Defence {get; set;} = 1;
    public string Weapon {get; set;} = "NoWeapon";
}

public class Weapon
{
    public double[] NoWeapon = new double[4];

    public Weapon()
    {
        NoWeapon[0] = 0;
        NoWeapon[1] = 0;
        NoWeapon[2] = 0;
        NoWeapon[3] = 0;
    }
}

public class EnemySlime
{
    public double Health {get; set;} = 15;
    public double Damage {get; set;} = 0.5;
    public double Speed {get; set;} = 1;
    public double Defence {get; set;} = 1.2;
    public string Weapon {get; set;} = "noWeapon";
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

        var thisFight = new Fight();

        bool gameEnd = false;

        bool hasFainted = false; 

        while (!gameEnd)
        {
            double newEnemyHealth = 0;
            double newPlayerHealth = 0;
            thisFight.PlayerAtack( out newEnemyHealth, random.Next(1,7) , slime.Health, slime.Defence, player.Damage);  

            slime.Health = newEnemyHealth;

            thisFight.EnemyAtack (out newPlayerHealth, random.Next(1,7), player.Health, player.Defence, slime.Damage);

            player.Health = newPlayerHealth;

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


        if (hasFainted == true )
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