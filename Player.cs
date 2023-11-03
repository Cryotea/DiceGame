namespace diceGame;
using diceGame.Weapon;
public class Player : IFighter
{
    public string Name {get; set;} = "Player";
    public double Health {get; set;} = 20;
    public double Damage {get; set;} = 1;
    public double Speed {get; set;} = 1;
    public double Defence {get; set;} = 1;
    public IWeapon Weapon {get; set;} = new CopperShortSword();
    public double MaxHealth {get; set;} = 20;
}