using diceGame.Weapon;
using diceGame;
using diceGame.Effects;
using diceGame.Stats;

namespace diceGame.Enemy;

public class EnemySlime : IEnemy
{
    public string Name {get; set;} = "Slime"; 
    public Health Health {get; set;} = new Health(15);
    public Stats.Strength Strength {get; set;} = new Stats.Strength(0.5);
    public Speed Speed {get; set;} = new Speed(0.5);
    public Defence Defence {get; set;} = new Defence(1.2);
    public IWeapon Weapon {get; set;} = new NoWeapon ();
    public int EXP {get; set;} = 3;
    public Effect Effect {get; set;} = new Effect();
    public int Money {get; set;} = 10;
    public LootTable LootTable {get; set;} = new LootTable();
    public object Clone()
    {
        return new EnemySlime()
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
        double OldStat = player.Health.MaxHealth;
        player.Health.MaxHealth += 5;
        Console.WriteLine($"{player.Name} got a stat up!\n Health : {OldStat} => {player.Health.MaxHealth}!");
    }

    public void GetExp(Player player)
    {
        player.EXP += EXP;
        Console.WriteLine($"{player.Name} got {EXP} EXP!");
        player.LevelUp();
    }

    public void GetMoney(Player player)
    {
        player.Money += Money;
        Console.WriteLine($"{player.Name} got {Money}$ !");
    }
}