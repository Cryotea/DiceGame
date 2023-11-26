using System.Security.Cryptography.X509Certificates;
using diceGame.Item;

namespace diceGame.Weapon;

public class PoisenCrossbow : IWeapon
{
    public string Id {get; set;} = "PoisenCrossbow";
    public int Amount {get; set;} 
    private int Turn = 1;
    private double Strength = 0;
    public void AttackPattern(IFighter attacker, IFighter defender)
    {
        var random = new Random();
        
        if (Turn == 1)
        {
            Strength = random.Next(0, 11);
            Console.WriteLine($"{attacker.Name} draws the Crossbow with {Strength} Strength");
        }
        if (Turn == 2)
        {
            int poisenLevel = random.Next(1,3);
            int poisenDuration = random.Next(1,3);
            double dice = random.Next(1,6);
            
            defender.Effect.Poisen.Item1 = poisenLevel;
            defender.Effect.Poisen.Item2 += poisenDuration;
            
            defender.Health = defender.Health - (Strength * 0.1) * dice + dice;
            double Damage = (Strength * 0.1) * dice + dice;
            Console.WriteLine($"{attacker.Name} rolled a {dice} and attacked {defender.Name} for {Damage}!");
        }
        Turn++;
        if (Turn == 3)Turn = 1;
    }
    public void EquipWeapon(Player player)
    {
        player.Weapon = new PoisenCrossbow();
        Console.WriteLine($"{player.Name} equiped a PoisenCrossbow");
    }

    public void Loot(Player player)
    {
        if(player.Inventory.PoisenCrossbow.Amount == 0)
        {
            player.Inventory.PoisenCrossbow.Amount = 1;
            Console.WriteLine($"{player.Name} got a PoisenCrossbow");
        }
    }
    public override string ToString()
    {
        return "PoisenCrossbow";
    }
}