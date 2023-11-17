namespace diceGame.Enemy;
using diceGame.Weapon;
using diceGame;


public class EnemySlime : IEnemy
{
    public string Name {get; set;} = "Slime"; 
    public double Health {get; set;} = 15;
    public double Damage {get; set;} = 0.5;
    public double Speed {get; set;} = 1;
    public double Defence {get; set;} = 1.2;
    public IWeapon Weapon {get; set;} = new NoWeapon ();
    public double MaxHealth {get; set;} = 15 ;
    public int EXP {get; set;} = 3;
    public object Clone()
    {
        return new EnemySlime()
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
        double OldStat = player.MaxHealth;
        player.MaxHealth += 5;
        Console.WriteLine($"{player.Name} got a stat up!\n Health : {OldStat} => {player.MaxHealth}!");
    }

    public void GetExp(Player player)
    {
        player.EXP += EXP;
        Console.WriteLine($"{player.Name} got {EXP} EXP!");
        player.LevelUp();
    }
}