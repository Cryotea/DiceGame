using diceGame.Weapon;

namespace diceGame;

public interface IFighter
{
    public string Name {get; set;}
    public double Health {get; set;} 
    public double Damage {get; set;} 
    public double Speed {get; set;} 
    public double Defence {get; set;} 
    public IWeapon Weapon {get; set;}
    public double MaxHealth {get; set;}
   
}