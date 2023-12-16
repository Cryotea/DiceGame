using Spectre.Console;

namespace diceGame.Weapon;

public class NoWeapon :BaseWeapon, IWeapon
{
    public string Id {get; set;} = "NoWeapon";
    public int Amount {get; set;} 
    public string AttackPattern(IFighter attacker, IFighter defender)
    {
        var random = new Random();
        double dice = random.Next(1,7);
        
        double DamageDone = Math.Round(dice * attacker.Strength.GetStat(attacker.Effect) / defender.Defence.GetStat(defender.Effect)  ,2);
        defender.Health.Current -= DamageDone;
        defender.Health.Current = Math.Round(defender.Health.Current, 2);
        return ($"\n{attacker.Name} rolled a [red]{dice}[/] and attacked {defender.Name} for [red]{DamageDone} Damage[/]. {defender.Name} has [green]{defender.Health.Current} HP[/]left");
    }
    public override string ToString()
    {
        return $"{Color}no Weapon[/]";
    }
}

