using System.Data;

public interface IFighter
{
    public string Name {get; set;}
    public double Health {get; set;} 
    public double Damage {get; set;} 
    public double Speed {get; set;} 
    public double Defence {get; set;} 
    public IWeapon Weapon {get; set;}
    public bool IsPlayer {get; set;}
}
public class Player : IFighter
{
    public string Name {get; set;} = "Player";
    public double Health {get; set;} = 20;
    public double Damage {get; set;} = 1;
    public double Speed {get; set;} = 1;
    public double Defence {get; set;} = 1;
    public IWeapon Weapon {get; set;} = new CopperShortSword();
    public bool IsPlayer {get; set;} = true;
}

public interface IWeapon
    {
        public void AttackPattern(IFighter attacker, IFighter defender);
    }

public class NoWeapon : IWeapon
{
    public void AttackPattern(IFighter attacker, IFighter defender)
    {
        var random = new Random();
        double dice = random.Next(1,7);
        Console.WriteLine("Press enter to throw the dice");
         if (attacker.IsPlayer == true)
         {
            Console.ReadLine();
         }
        defender.Health = defender.Health - dice * attacker.Damage / defender.Defence;
        Console.WriteLine($"{attacker.Name} rolled a {dice} and attacked {defender.Name} for {dice * attacker.Damage / defender.Defence} {defender.Name} has {defender.Health} HP left");
        
    }
}

public class CopperShortSword : IWeapon
{
     public void AttackPattern(IFighter attacker, IFighter defender)
    {
        var random = new Random();
        double dice = random.Next(1,7);
        Console.WriteLine("Press enter to throw the dice");
         if (attacker.IsPlayer == true)
         {
            Console.ReadLine();
         }
        defender.Health = defender.Health - (dice + attacker.Speed) * attacker.Damage  / defender.Defence;
        Console.WriteLine($"{attacker.Name} rolled a {dice} and attacked {defender.Name} for {(dice + attacker.Speed)* attacker.Damage / defender.Defence} {defender.Name} has {defender.Health} HP left");
        
    }
}

public class EnemySlime : IFighter
{
    public string Name {get; set;} = "Slime"; 
    public double Health {get; set;} = 15;
    public double Damage {get; set;} = 0.5;
    public double Speed {get; set;} = 1;
    public double Defence {get; set;} = 1.2;
    public IWeapon Weapon {get; set;} = new NoWeapon ();
    public bool IsPlayer {get; set;} = false;
}



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