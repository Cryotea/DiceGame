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
    public void EquipWeapon(Player player)
    {
        player.Weapon = new NoWeapon();
        Console.WriteLine($"{player.Name} deequiped their weapon");

    }
    
    public void Loot(Player player)
    {
        if (player.Inventory.NoWeapon.Item1 == 0)
        {
        player.Inventory.Bow.Item1 = 1;
        //Console.WriteLine($"{player.Name} got a NoWeapon");
        }
    }
    public override string ToString()
    {
        return "no Weapon";
    }
}

