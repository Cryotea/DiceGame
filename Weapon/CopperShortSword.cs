namespace diceGame.Weapon;

public class CopperShortSword : IWeapon
{
     public void AttackPattern(IFighter attacker, IFighter defender)
    {
        var random = new Random();
        double dice = random.Next(1,7);
        
        defender.Health = defender.Health - (dice + attacker.Speed) * attacker.Damage  / defender.Defence;
        Console.WriteLine($"{attacker.Name} rolled a {dice} and attacked {defender.Name} for {(dice + attacker.Speed)* attacker.Damage / defender.Defence} Damage. {defender.Name} has {defender.Health} HP left");
        
    }
    public void EquipWeapon(Player player)
    {
        player.Weapon = new CopperShortSword();
        Console.WriteLine($"{player.Name} equiped a CopperShortSword");
    }

    public void Loot(Player player)
    {
        if (player.Inventory.CopperShortSword.Item1 == 0)
        {
        player.Inventory.CopperShortSword.Item1 = 1;
        Console.WriteLine($"{player.Name} got a CopperShortSword");
        }
    }
    public override string ToString()
    {
        return "CopperShortSword";
    }
}