using diceGame.Enemy;
using diceGame.Item;

namespace diceGame;

public class LootTable
{
    /// <summary>
    /// ItemId, percent chance
    /// </summary>
    (string,int)[] GenericLootTable =
    {
        ("SmallPotion",100),
        ("MediumPotion", 50),
        ("PotionOfRegenaration",40),
        ("GoldenFonduePizza", 10)
    };
    
    public void GetLootTableItems(Player player)
    {
        var random = new Random();
        foreach((string, int)item in GenericLootTable)
        {
            int dropchance = random.Next(1,101);
            if (dropchance <= item.Item2)
            {
                player.Inventory.GainItem(item.Item1, 1);
                Console.WriteLine($"{player.Name} got a {item.Item1}!");
            }
        }
    }

    public void GetWeaponDrop(Player player,IEnemy enemy)
    {
        var random = new Random();
        int dropchance = random.Next(1,101);
        if (dropchance <= 30)
        {
            player.Inventory.GainWeapon(enemy.Weapon.Id);
            Console.WriteLine($"{player.Name} got a {enemy.Weapon}!");
        }
    }
}