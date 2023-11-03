namespace diceGame.Enemy;
using diceGame.Weapon;
using diceGame;

public class EnemyKnight : IFighter
{
    public string Name {get; set;} = "Knight"; 
    public double Health {get; set;} = 10;  
    public double Damage {get; set;} = 1;
    public double Speed {get; set;} = 0.5;
    public double Defence {get; set;} = 1;
    public IWeapon Weapon {get; set;} = new IronSword ();
    public double MaxHealth{get; set;} = 10;
    
}