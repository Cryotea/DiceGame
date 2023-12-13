using diceGame.Weapon;
using diceGame;
using diceGame.Effects;
using diceGame.Stats;
using Spectre.Console;

namespace diceGame.Enemy;
public class EnemyKnight : IEnemy
{
    public string Name {get; set;} = $"{ColorManager.BasicEnemyColor}Knight[/]"; 
    public Health Health {get; set;} = new Health(10);  
    public Stats.Strength Strength {get; set;} = new Stats.Strength(1);
    public Speed Speed {get; set;} = new Speed(0.5);
    public Defence Defence {get; set;} = new Defence(1.5);
    public IWeapon Weapon {get; set;} = new IronSword ();
    public int EXP {get; set;} = 5;
    public Effect Effect {get; set;} = new Effect();
    public int Money {get; set;} = 10;
    public LootTable LootTable {get; set;} = new LootTable();
    public object Clone()
    {
        return new EnemyKnight()
        {
            Name = Name,
            Health = Health,
            Strength = Strength,
            Speed = Speed,
            Defence = Defence,
            Weapon = Weapon,
            
        };
    }
     public void GetStats(Player player)
    {
        double OldStat = player.Strength.Max;
        player.Strength.Max += 0.2;
        AnsiConsole.MarkupLine($"{player.Name} got a stat up!\n {Strength.ToString()} : {OldStat} => {player.Strength.Max}!");
    }
    public void GetExp(Player player)
    {
        player.EXP += EXP;
        AnsiConsole.MarkupLine($"{player.Name} got {EXP} EXP!");
        player.LevelUp();
    }

    public void GetMoney(Player player)
    {
        player.Money += Money;
        AnsiConsole.MarkupLine($"{player.Name} got {Money}$ !");
    }
}

