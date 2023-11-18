using diceGame.Weapon;
using diceGame;
using diceGame.Effects;

namespace diceGame.Enemy;
public class EnemyKnight : IEnemy
{
    public string Name {get; set;} = "Knight"; 
    public double Health {get; set;} = 10;  
    public double Damage {get; set;} = 1;
    public double Speed {get; set;} = 0.5;
    public double Defence {get; set;} = 1;
    public IWeapon Weapon {get; set;} = new IronSword ();
    public double MaxHealth{get; set;} = 10;
    public int EXP {get; set;} = 5;
    public Effect Effect {get; set;} = new Effect();
    public object Clone()
    {
        return new EnemyKnight()
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
        player.Damage += 0.2;
        Console.WriteLine($"{player.Name} got a stat up!\n Damage : {OldStat} => {player.Damage}!");
    }
    public void GetExp(Player player)
    {
        player.EXP += EXP;
        Console.WriteLine($"{player.Name} got {EXP} EXP!");
        player.LevelUp();
    }
}

