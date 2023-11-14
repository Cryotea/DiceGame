namespace diceGame.Weapon;

public class Bow : IWeapon
{
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
        defender.Health = defender.Health - (((attacker.Speed + dice )* attacker.Damage) * critMultiplier) / defender.Defence;
        Console.WriteLine($"{attacker.Name} rolled a {dice} {(isCrit ? "and got a CriticalHit " : "")}and attacked {defender.Name} for {(((attacker.Speed + dice )* attacker.Damage) * critMultiplier) / defender.Defence} Damage. {defender.Name} has {defender.Health} Hp left");
        
    }

    public override string ToString()
    {
        return "Bow";
    }
}