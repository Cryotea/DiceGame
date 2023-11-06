using diceGame.Weapon;
using diceGame;
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
    
}

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