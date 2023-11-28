using diceGame.Weapon;
using diceGame;
using System.Dynamic;
using diceGame.Effects;
using diceGame.Item;

namespace diceGame.Enemy;
public class EnemyArcher : IEnemy
{
    public string Name {get; set;} = "Archer"; 
    public double Health {get; set;} = 10;
    public double Damage {get; set;} = 1;
    public double Speed {get; set;} = 1.5;
    public double Defence {get; set;} = 1.2;
    public IWeapon Weapon {get; set;} = new Bow ();
    public double MaxHealth {get; set;} = 10 ;
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
            Damage = Damage,
            Speed = Speed,
            Defence = Defence,
            Weapon = Weapon,
            MaxHealth = MaxHealth,
        };
    }

    public void GetStats(Player player)
    {
        double OldStat = player.Speed;
        player.Speed += 0.2;
        Console.WriteLine($"{player.Name} got a stat up!\n Speed : {OldStat} => {player.Speed}!");
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