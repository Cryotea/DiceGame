namespace diceGame.Enemy;
using diceGame.Weapon;
using diceGame;

public class EnemyKnight : IFighter
{
    public string Name {get; set;} = "Knight"; 
    public double Health {get; set;} = 30;
    public double Damage {get; set;} = 1.2;
    public double Speed {get; set;} = 0.5;
    public double Defence {get; set;} = 1;
    public IWeapon Weapon {get; set;} = new IronSword ();
    
}