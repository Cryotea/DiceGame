namespace diceGame.Enemy.Boss;
using diceGame.Weapon;
using diceGame;
using diceGame.Effects;
using diceGame.Stats;
using Spectre.Console;

public class BossKnight : IBoss
{
    public string Name {get; set;} = $"{ColorManager.BasicEnemyColor}BossKnight[/]";

    public string BaseEnemy { get; set; } = "Knight";
    
    public string Id { get; set; } = "BossKnight";
    public Health Health {get; set;} = new Health(50);  
    public Stats.Strength Strength {get; set;} = new Stats.Strength(2);
    public Speed Speed {get; set;} = new Speed(0.5);
    public Defence Defence {get; set;} = new Defence(1.9);
    public IWeapon Weapon {get; set;} = new IronSword ();
    public int EXP {get; set;} = 20;
    public Effect Effect {get; set;} = new Effect();
    public int Money {get; set;} = 40;
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
        player.Strength.Max += 1;
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