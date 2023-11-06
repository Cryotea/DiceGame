namespace diceGame.Weapon;

public class CopperShortSword : IWeapon
{
     public void AttackPattern(IFighter attacker, IFighter defender)
    {
        var random = new Random();
        double dice = random.Next(1,7);
        
         if (attacker is Player)
         {
             Console.WriteLine("Press enter to throw the dice");
             Console.ReadLine();
           
         }
        defender.Health = defender.Health - (dice + attacker.Speed) * attacker.Damage  / defender.Defence;
        Console.WriteLine($"{attacker.Name} rolled a {dice} and attacked {defender.Name} for {(dice + attacker.Speed)* attacker.Damage / defender.Defence} Damage. {defender.Name} has {defender.Health} HP left");
        
    }
}