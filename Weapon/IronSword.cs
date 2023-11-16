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
    public void EquipWeapon(Player player)
    {
        player.Weapon = new IronSword();
        Console.WriteLine($"{player.Name} equiped a Iron Sword");
    }
    public void Loot(Player player)
    {
        if (player.Inventory.IronSword.Item1 == 0)
        {
        player.Inventory.IronSword.Item1 = 1;
        Console.WriteLine($"{player.Name} got a IronSword");
        }
    }
    public override string ToString()
    {
        return "IronSword";
    }
}