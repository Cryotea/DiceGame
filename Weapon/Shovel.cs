namespace diceGame.Weapon;

public class Shovel: IWeapon
{
    public string Id {get; set;} = "Shovel";
    public int Amount {get; set;} 
    public void AttackPattern(IFighter attacker, IFighter defender)
    {
        var random = new Random();
        double dice = random.Next(3,7);
        double dice2 = random.Next(1,3);
        
        defender.Health.HP = defender.Health.HP - (dice2 * attacker.Strength.GetStat(attacker) / defender.Defence.GetStat(defender) +(dice +(defender.Strength.GetStat(defender) * 0.1)));
        Console.WriteLine($"{attacker.Name} rolled a {dice} and a {dice2} and digged a hole, and kicked {defender.Name} for {dice2 * attacker.Strength.GetStat(attacker) / defender.Defence.GetStat(defender)}. {defender.Name} fell in the hole and took {dice +(defender.Strength.GetStat(defender) * 0.1)} fall damage!");
        
    }
    public override string ToString()
    {
        return "Shovel";
    }
}