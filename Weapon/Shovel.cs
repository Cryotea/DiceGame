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
        
        defender.Health = defender.Health - (dice2 * attacker.Damage / defender.Defence +(dice +(defender.Damage * 0.1)));
        Console.WriteLine($"{attacker.Name} rolled a {dice} and a {dice2} and digged a hole, and kicked {defender.Name} for {dice2 * attacker.Damage / defender.Defence}. {defender.Name} fell in the hole and took {dice +(defender.Damage * 0.1)} fall damage!");
        
    }
    public void EquipWeapon(Player player)
    {
        player.Weapon = new Shovel();
        Console.WriteLine($"{player.Name} equiped a Shovel");
    }
    public override string ToString()
    {
        return "Shovel";
    }
}