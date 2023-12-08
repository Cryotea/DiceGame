namespace diceGame;

using diceGame.Item;
using diceGame.Weapon;
using diceGame.Enemy;
using diceGame.Effects;
using diceGame.Stats;

public class Player : IFighter
{
    public string Name {get; set;} = "Player";
    public Health Health {get; set;} = new Health(20);
    public Stats.Strength Strength {get; set;} = new Stats.Strength(1);
    public Speed Speed {get; set;} = new Speed(1);
    public Defence Defence {get; set;} = new Defence(1);
    public IWeapon Weapon {get; set;} = new CopperShortSword();
    public int EXP {get; set;} = 0;
    public double Level {get; set;} = 0;
    public Effect Effect {get; set;} = new Effect();
    public Inventory Inventory {get; set;} = new Inventory(); 
    public int Money {get; set;} = 10;

    public bool PlayerMove(Player player, IFighter enemy, bool usedMove)
    {
        
        Console.WriteLine($"what is {player.Name} doing ");
        Console.WriteLine($"|1 = Attack |2 = Inventory |3 = {player.Name}'s Stats ");
        string input = Console.ReadLine();
        // switch instead of if
        if (input == "1")
        {
            Effect.GetBuffed(this);
            Effect.GetDebuffed(this);
            player.Weapon.AttackPattern(player, enemy);
            usedMove = true;
            return usedMove;
        }
        if (input == "2")
        {
            Inventory.OpenInventory(this);
            usedMove = false;
            return usedMove;
        }
        if (input == "3")
        {
            player.ShowStats();
        }
        else Console.WriteLine("Please Input a Valid Number");
        usedMove = false;
        return usedMove;
        
    }

    public void ShowStats()
    {
        Console.WriteLine($"Name :{Name}\tLvl:{Level} \tHP:{Health.Current}/{Health.Max} \nDMG:{Strength.Max} \t\tWeapon:{Weapon} \nSpeed:{Speed.Max} \tDefence:{Defence.Max} ");
        this.Effect.Info();
        Console.WriteLine("press enter to go back");
        Console.ReadLine();
    }

    public void LevelUp()
    {
        while (EXP >= 10)
        {
            (string, double)[] OldStats;
            (string, double)[] NewStats;
            OldStats = new (string, double)[]
            {
                ("Level", Level),
                ("MaxHealth", Health.Max),
                ("Damage", Strength.Max),
                ("Speed", Speed.Max),
                ("Defence", Defence.Max),
                
            };
            
            Level++;
            EXP -= 10;
            Health.Max = Health.Max + (Health.Max * 0.1);
            Strength.Max = Strength.Max + (Strength.Max * 0.1);
            Speed.Max = Speed.Max + (Speed.Max * 0.1);
            Defence.Max = Defence.Max + (Defence.Max * 0.1);

            NewStats = new (string, double)[]
            {
                ("Level", Level),
                ("MaxHealth", Health.Max),
                ("Damage", Strength.Max),
                ("Speed", Speed.Max),
                ("Defence", Defence.Max),
            };

            Console.WriteLine($"{Name} got a Level Up!");
            Console.WriteLine($" Level {OldStats[0].Item2} => {NewStats[0].Item2}");

            int count = 1;
            while(count < 5)
            {   
                Console.WriteLine($"{OldStats[count].Item1} : {OldStats[count].Item2} => {NewStats[count].Item2}");
                count++;
            }
    
        }
    }

}