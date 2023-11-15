
using diceGame.Item;
using diceGame;
namespace diceGame;


public class Loot
{
    IItem[] lootPool = 
    {
        new SmallPotion(),
        new MediumPotion(),
    };

    IItem[] premiumLootPool =
    {
        new GoldenFonduePizza(),
    };

    public void GetLoot(Player player, IFighter enemy)
    {
        var random = new Random();
        int WeaponDrop = random.Next(1,4);
        int SpecialDrop = random.Next(1,4);
        if (WeaponDrop == 1)
        {
            int WeaponIndex = Array.IndexOf(player.WeaponList, enemy.Weapon);
            player.WeaponList[WeaponIndex].Item1 = true;
        }

        IItem loot = lootPool[random.Next(0, lootPool.Length)];
        int itemNumber = Array.IndexOf(player.ItemList,loot);
        player.ItemList[itemNumber].Item1++;
        Console.WriteLine($"{player.Name} got a {loot}!");
        
        if (SpecialDrop == 1)
        {
            IItem specialloot = premiumLootPool[random.Next(0, lootPool.Length)];
            int specialitemNumber = Array.IndexOf(player.ItemList, specialloot);
            player.ItemList[specialitemNumber].Item1++;
            Console.WriteLine($"{player.Name} got a {specialloot}!");
        }

    }
}