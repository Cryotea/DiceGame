using Spectre.Console;

namespace diceGame.Weapon;

public class Shovel:BaseWeapon, IWeapon
{
    public string Id {get; set;} = "Shovel";
    public int Amount {get; set;} 
    public string AttackPattern(IFighter attacker, IFighter defender)
    {
        var random = new Random();
        double dice = random.Next(3,7);
        double dice2 = random.Next(1,3);
        
        double DamageDone = Math.Round((dice2 * attacker.Strength.GetStat(attacker.Effect) / defender.Defence.GetStat(defender.Effect) +(dice +(defender.Strength.GetStat(defender.Effect) * 0.1))) ,2) ;
        defender.Health.Current -= DamageDone;
        defender.Health.Current = Math.Round(defender.Health.Current, 2);
        return ($"\n{attacker.Name} rolled a [red]{dice} [/]and a [red]{dice2}[/]and dug a hole, and [red]kicked[/] {defender.Name} for[red] {dice2 * attacker.Strength.GetStat(attacker.Effect) / defender.Defence.GetStat(defender.Effect)}[/]. {defender.Name} fell in the hole and took[red] {dice +(defender.Strength.GetStat(defender.Effect) * 0.1)} fall damage[/]!");
        
    }
    public override string ToString()
    {
        return $"{Color}Shovel[/]";
    }
}