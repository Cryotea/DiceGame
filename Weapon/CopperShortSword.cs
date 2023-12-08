namespace diceGame.Weapon;

public class CopperShortSword : IWeapon
{
    public string Id {get; set;} = "CopperShortSword";
    public int Amount {get; set;} 
    public void AttackPattern(IFighter attacker, IFighter defender)
    {
        var random = new Random();
        double dice = random.Next(1,7);
        
        defender.Health.Current = defender.Health.Current - (dice + attacker.Speed.GetStat(attacker.Effect)) * attacker.Strength.GetStat(attacker.Effect)  / defender.Defence.GetStat(defender.Effect);
        Console.WriteLine($"{attacker.Name} rolled a {dice} and attacked {defender.Name} for {(dice + attacker.Speed.GetStat(attacker.Effect))* attacker.Strength.GetStat(attacker.Effect) / defender.Defence.GetStat(defender.Effect)} Damage. {defender.Name} has {defender.Health.Current} HP left");
        
    }
    public override string ToString()
    {
        return "CopperShortSword";
    }
}