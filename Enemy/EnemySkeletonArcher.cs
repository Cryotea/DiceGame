using diceGame.Weapon;
using diceGame.Effects;
using diceGame;

namespace diceGame.Enemy;

public class EnemySkeletonArcher : IEnemy
{
    public string Name {get; set;} = "SkeletonArcher";
    public double Health {get; set;} = 20;  
    public double Damage {get; set;} = 1;
    public double Speed {get; set;} = 0.5;
    public double Defence {get; set;} = 0.9;
    public IWeapon Weapon {get; set;} = new PoisenCrossbow ();
    public double MaxHealth{get; set;} = 20;
    public int EXP {get; set;} = 12;
    public Effect Effect {get; set;} = new Effect();
    public object Clone()
    {
        return new EnemySkeletonArcher()
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
        double OldStat = player.Damage;
        player.Damage += 0.3;
        Console.WriteLine($"{player.Name} got a stat up!\n Damage : {OldStat} => {player.Damage}!");
    }
    public void GetExp(Player player)
    {
        player.EXP += EXP;
        Console.WriteLine($"{player.Name} got {EXP} EXP!");
        player.LevelUp();
    }
}