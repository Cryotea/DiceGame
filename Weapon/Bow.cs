
using Spectre.Console;

namespace diceGame.Weapon;

public class Bow :BaseWeapon, IWeapon
{   
    public string Id {get; set;} = "Bow";
    public int Amount {get; set;} 
    public void AttackPattern(IFighter attacker, IFighter defender)
    {
        var random = new Random();
        double dice = random.Next(1,11);
        double critDice = random.Next(1,5);
        double critMultiplier = 1;
        bool isCrit = false;

         if (critDice == 4) 
        {
            critMultiplier += 0.25;
            isCrit = true;
        }
        defender.Health.Current = defender.Health.Current - (((attacker.Speed.GetStat(attacker.Effect) + dice )* attacker.Strength.GetStat(attacker.Effect)) * critMultiplier) / defender.Defence.GetStat(defender.Effect);
        AnsiConsole.MarkupLine($"\n{attacker.Name} rolled a [red]{dice}[/] {(isCrit ? "and got a [red]CriticalHit[/] " : "")}and attacked {defender.Name} for [red]{(((attacker.Speed.GetStat(attacker.Effect) + dice )* attacker.Strength.GetStat(attacker.Effect)) * critMultiplier) / defender.Defence.GetStat(defender.Effect)} Damage[/]. {defender.Name} has [green]{defender.Health.Current} Hp [/] left");
        
    }   
    public override string ToString()
    {
        return $"{Color}Bow[/]";
    }
}