using diceGame.Weapon;
using diceGame.Effects;
using diceGame;
using diceGame.Stats;
using Spectre.Console;

namespace diceGame.Enemy;

public class EnemySkeletonArcher : IEnemy
{
    public string Name {get; set;} = "SkeletonArcher";
    public Health Health {get; set;} = new Health(20);  
    public Stats.Strength Strength {get; set;} = new Stats.Strength(1);
    public Speed Speed {get; set;} = new Speed(0.5);
    public Defence Defence {get; set;} = new Defence(0.9);
    public IWeapon Weapon {get; set;} = new PoisenCrossbow ();
    public int EXP {get; set;} = 12;
    public Effect Effect {get; set;} = new Effect();
    public int Money {get; set;} = 10;
    public LootTable LootTable {get; set;} = new LootTable();
    public object Clone()
    {
        return new EnemySkeletonArcher()
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
        player.Strength.Max += 0.3;
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