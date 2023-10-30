namespace diceGame.Enemy;
using diceGame.Weapon;
using diceGame;

public class EnemySlime : IFighter
{
    public string Name {get; set;} = "Slime"; 
    public double Health {get; set;} = 15;
    public double Damage {get; set;} = 0.5;
    public double Speed {get; set;} = 1;
    public double Defence {get; set;} = 1.2;
    public IWeapon Weapon {get; set;} = new NoWeapon ();
    
}