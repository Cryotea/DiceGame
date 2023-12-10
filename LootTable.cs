using diceGame.Enemy;
using diceGame.Item;
using Spectre.Console;

namespace diceGame;

public class LootTable
{
    // TODO: Use LootTableItems
    
    /// <summary>
    /// ItemId, percent chance
    /// </summary>
    (string,int,string)[] GenericLootTable =
    {
        (new SmallPotion().ToString(),100,new SmallPotion().Id),
        (new MediumPotion().ToString(), 50, new MediumPotion().Id),
        (new PotionOfRegenaration().ToString(),40, new PotionOfRegenaration().Id),
        (new GoldenFonduePizza().ToString(), 10, new GoldenFonduePizza().Id)
    };
    
    public void GetLootTableItems(Player player)
    {
        var random = new Random();
        foreach((string, int, string )item in GenericLootTable)
        {
            int dropchance = random.Next(1,101);
            if (dropchance <= item.Item2)
            {
                player.Inventory.GainItem(item.Item3, 1);
                AnsiConsole.MarkupLine($"{player.Name} got a {item.Item1}!");
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
            AnsiConsole.MarkupLine($"{player.Name} got a {enemy.Weapon}!");
        }
    }
}