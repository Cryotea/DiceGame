using diceGame.Weapon;
using diceGame;
using System.Dynamic;
using diceGame.Effects;
using diceGame.Item;
using diceGame.Stats;
using Spectre.Console;

namespace diceGame.Enemy;
public class EnemyArcher : IEnemy
{
    public string Name {get; set;} = "Archer"; 
    public Health Health {get; set;} = new Health(10);
    public Stats.Strength Strength {get; set;} = new Stats.Strength(1);
    public Speed Speed {get; set;} = new Speed(1.5);
    public Defence Defence {get; set;} = new Defence(1.2);
    public IWeapon Weapon {get; set;} = new Bow ();
    public int EXP {get; set;} = 8;
    public Effect Effect {get; set;} = new Effect();
    public int Money {get; set;} = 10;
    public LootTable LootTable {get; set;} = new LootTable();
    public object Clone()
    {
        return new EnemyArcher()
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
        double OldStat = player.Speed.Max;
        player.Speed.Max += 0.2;
        AnsiConsole.MarkupLine($"{player.Name} got a stat up!\n Speed : {OldStat} => {player.Speed.Max}!");
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