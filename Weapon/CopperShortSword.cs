namespace diceGame.Weapon;

public class CopperShortSword : IWeapon
{
    public string Id {get; set;} = "CopperShortSword";
    public int Amount {get; set;} 
    public void AttackPattern(IFighter attacker, IFighter defender)
    {
        var random = new Random();
        double dice = random.Next(1,7);
        
        defender.Health.HP = defender.Health.HP - (dice + attacker.Speed.GetStat(attacker)) * attacker.Strength.GetStat(attacker)  / defender.Defence.GetStat(defender);
        Console.WriteLine($"{attacker.Name} rolled a {dice} and attacked {defender.Name} for {(dice + attacker.Speed.GetStat(attacker))* attacker.Strength.GetStat(attacker) / defender.Defence.GetStat(defender)} Damage. {defender.Name} has {defender.Health.HP} HP left");
        
    }
    public override string ToString()
    {
        return "CopperShortSword";
    }
}