using diceGame.Item;
using diceGame.Weapon;
using diceGame.Enemy;
using diceGame.Effects;
using diceGame.Stats;
using Spectre.Console;

namespace diceGame;
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
        
        
        
        string CurrentPlayerMove = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title($"\nwhat is {player.Name} doing ?")
                .PageSize(10)
                .AddChoices(new[] {
                    "Attack", "Inventory", $"{player.Name}'s Stats "
                }));
        
        // switch instead of if
        switch (CurrentPlayerMove)
        {
            case "Attack":
                Effect.GetBuffed(this);
                Effect.GetDebuffed(this);
                player.Weapon.AttackPattern(player, enemy);
                usedMove = true;
                return usedMove;
                
            case "Inventory":
                Inventory.OpenInventory(this);
                usedMove = false;
                return usedMove;
            
            default:
                player.ShowStats();
                return false;
                
        }
        
    }

    public void ShowStats()
    {
        AnsiConsole.MarkupLine($"Name :{Name}\tLvl:{Level} \tHP:{Health.Current}/{Health.Max} \nDMG:{Strength.Max} \t\tWeapon:{Weapon} \nSpeed:{Speed.Max} \tDefence:{Defence.Max} ");
        this.Effect.Info();
        AnsiConsole.MarkupLine("press enter to go back");
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
                (Health.ToString(), Health.Max),
                (Strength.ToString(), Strength.Max),
                (Speed.ToString(), Speed.Max),
                (Defence.ToString(), Defence.Max),
                
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
                (Health.ToString(), Health.Max),
                (Strength.ToString(), Strength.Max),
                (Speed.ToString(), Speed.Max),
                (Defence.ToString(), Defence.Max),
            };
            
            var panel = new Panel($"{Name} got a Level Up" +
                                  $"\n{OldStats[0].Item2} => {NewStats[0].Item2}" +
                                  $"\n{NewStats[1].Item1} up!" +
                                  $"\n{OldStats[1].Item1} : {OldStats[1].Item2} => {NewStats[1].Item2}" +
                                  $"\n{NewStats[2].Item1} up!" +
                                  $"\n{OldStats[2].Item1} : {OldStats[1].Item2} => {NewStats[1].Item2}"+
                                  $"\n{NewStats[3].Item1} up!" +
                                  $"\n{OldStats[3].Item1} : {OldStats[1].Item2} => {NewStats[1].Item2}" +
                                  $"\n{NewStats[4].Item1} up!" +
                                  $"\n{OldStats[4].Item1} : {OldStats[1].Item2} => {NewStats[1].Item2}"
                                  );
            AnsiConsole.Write(panel);
    
        }
    }

}