namespace diceGame.Weapon;

public class IronSword: IWeapon
{
    public string Id {get; set;} = "IronSword";
    public int Amount {get; set;} 
     public void AttackPattern(IFighter attacker, IFighter defender)
    {
        var random = new Random();
        double dice1 = random.Next(1,5);
        double dice2 = random.Next(1,5);
        
      
        defender.Health.HP = defender.Health.HP - (dice1 + dice2) * attacker.Strength.GetStat(attacker)  / defender.Defence.GetStat(defender);
        Console.WriteLine($"{attacker.Name} rolled a {dice1} and a {dice2} and attacked {defender.Name} for {(dice1 + dice2) * attacker.Strength.GetStat(attacker) / defender.Defence.GetStat(defender)} Damage. {defender.Name} has {defender.Health.HP} HP left");
        
    }
    public override string ToString()
    {
        return "IronSword";
    }
}