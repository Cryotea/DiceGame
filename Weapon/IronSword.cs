using Spectre.Console;

namespace diceGame.Weapon;

public class IronSword:BaseWeapon, IWeapon
{
    public string Id {get; set;} = "IronSword";
    public int Amount {get; set;} 
     public string AttackPattern(IFighter attacker, IFighter defender)
    {
        var random = new Random();
        double dice1 = random.Next(1,5);
        double dice2 = random.Next(1,5);
        
      
        double DamageDone = Math.Round((dice1 + dice2) * attacker.Strength.GetStat(attacker.Effect)  / defender.Defence.GetStat(defender.Effect) ,2);
        defender.Health.Current -= DamageDone;
        defender.Health.Current = Math.Round(defender.Health.Current, 2);
        return ($"\n{attacker.Name} rolled a [red]{dice1}[/] and a [red]{dice2}[/] and attacked {defender.Name} for [red]{DamageDone} Damage[/]. {defender.Name} has[green] {defender.Health.Current} HP[/] left");
        
    }
    public override string ToString()
    {
        return $"{Color}IronSword[/]";
    }
}