namespace diceGame.Weapon;

public class Bow : IWeapon
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
        defender.Health.HP = defender.Health.HP - (((attacker.Speed.GetStat(attacker) + dice )* attacker.Strength.GetStat(attacker)) * critMultiplier) / defender.Defence.GetStat(defender);
        Console.WriteLine($"{attacker.Name} rolled a {dice} {(isCrit ? "and got a CriticalHit " : "")}and attacked {defender.Name} for {(((attacker.Speed.GetStat(attacker) + dice )* attacker.Strength.GetStat(attacker)) * critMultiplier) / defender.Defence.GetStat(defender)} Damage. {defender.Name} has {defender.Health.HP} Hp left");
        
    }   
    public override string ToString()
    {
        return "Bow";
    }
}