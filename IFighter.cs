using diceGame.Weapon;
using diceGame.Effects;
using diceGame.Stats;

namespace diceGame;

public interface IFighter
{
    public string Name {get; set;}
    public Health Health {get; set;} 
    public Stats.Strength Strength {get; set;} 
    public Speed Speed {get; set;} 
    public Defence Defence {get; set;} 
    public IWeapon Weapon {get; set;}
    public int EXP {get; set;}
    public Effect Effect {get; set;}
    public int Money {get; set;}
}