
using diceGame.Item;
using Spectre.Console;

namespace diceGame.Weapon;

public class PoisenCrossbow :BaseWeapon, IWeapon
{
    public string Id {get; set;} = "PoisenCrossbow";
    public int Amount {get; set;} 
    private int Turn = 1;
    private double Strength = 0;
    public void AttackPattern(IFighter attacker, IFighter defender)
    {
        var random = new Random();
        
        switch (Turn % 2)
        {
            case 0:
                Strength = random.Next(0, 11);
                AnsiConsole.MarkupLine($"\n{attacker.Name} draws the Crossbow with [red]{Strength} Strength[/]");
                break;
            
            case 1:
                int poisenLevel = random.Next(1,3);
                int poisenDuration = random.Next(1,3);
                double dice = random.Next(1,6);

                defender.Effect.Poisen.Item1 = poisenLevel;
                defender.Effect.Poisen.Item2 += poisenDuration;

                double DamageDone = Math.Round((Strength * 0.1) * dice + dice  ,2);
                defender.Health.Current -= DamageDone;
                defender.Health.Current = Math.Round(defender.Health.Current, 2);
                AnsiConsole.MarkupLine($"{attacker.Name} rolled a [red]{dice}[/] and attacked {defender.Name} for [red]{DamageDone} Damage[/]! {defender.Name} has[green] {defender.Health.Current} HP[/] left!");
                break;
        }
    }
    public override string ToString()
    {
        return $"{Color}PoisonCrossbow[/]";
    }
}