
using diceGame.Item;
using diceGame;
using diceGame.Weapon;
namespace diceGame;


public class Loot
{

    public void GetLoot(Player player, IFighter enemy)
    {
        var random = new Random();
        int Loot = random.Next(1,3);
        int RareLootChance = random.Next(1,5);
        int WeaponDropChance = random.Next(1,4);
        
        //use switchcases instead of if
        if(Loot == 1)
        {
            player.Inventory.SmallPotion.Amount ++;
            Console.WriteLine($"{player.Name} got a {player.Inventory.SmallPotion}");
        }
        if(Loot == 2)
        {
            player.Inventory.MediumPotion.Amount++;
            Console.WriteLine($"{player.Name} got a {player.Inventory.MediumPotion}");
        }

        if (RareLootChance == 1)
        {
            int RareLoot = random.Next(1,2);

            if (RareLoot == 1)
            {
                player.Inventory.GoldenFonduePizza.Amount++;
                Console.WriteLine($"{player.Name} got a {player.Inventory.GoldenFonduePizza}");
            }
        }

        if (WeaponDropChance == 1)
        {
            enemy.Weapon.Loot(player);
        }
    }

}