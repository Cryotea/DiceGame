using diceGame.Weapon;
using diceGame.Effects;

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
    public int EXP {get; set;}
    public Effect Effect {get; set;}
    public int Money {get; set;}
}