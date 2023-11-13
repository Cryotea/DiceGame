namespace diceGame.Weapon;

public class IronSword: IWeapon
{
     public void AttackPattern(IFighter attacker, IFighter defender)
    {
        var random = new Random();
        double dice1 = random.Next(1,5);
        double dice2 = random.Next(1,5);
        
      
        defender.Health = defender.Health - (dice1 + dice2) * attacker.Damage  / defender.Defence;
        Console.WriteLine($"{attacker.Name} rolled a {dice1} and a {dice2} and attacked {defender.Name} for {(dice1 + dice2) * attacker.Damage / defender.Defence} Damage. {defender.Name} has {defender.Health} HP left");
        
    }
}