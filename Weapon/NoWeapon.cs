namespace diceGame.Weapon;

public class NoWeapon : IWeapon
{
    public void AttackPattern(IFighter attacker, IFighter defender)
    {
        var random = new Random();
        double dice = random.Next(1,7);
        
        defender.Health = defender.Health - dice * attacker.Damage / defender.Defence;
        Console.WriteLine($"{attacker.Name} rolled a {dice} and attacked {defender.Name} for {dice * attacker.Damage / defender.Defence} Damage. {defender.Name} has {defender.Health} HP left");
        
    }
}

