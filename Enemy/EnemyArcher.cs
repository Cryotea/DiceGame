namespace diceGame.Enemy;
using diceGame.Weapon;
using diceGame;


public class EnemyArcher : IEnemy
{
    public string Name {get; set;} = "Archer"; 
    public double Health {get; set;} = 10;
    public double Damage {get; set;} = 1;
    public double Speed {get; set;} = 1.5;
    public double Defence {get; set;} = 1.2;
    public IWeapon Weapon {get; set;} = new Bow ();
    public double MaxHealth {get; set;} = 10 ;
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
        player.Speed += 0.2;
    }
}