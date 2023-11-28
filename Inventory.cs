using diceGame.Effects.Debuffs;
using diceGame.Item;
using diceGame.Weapon;

namespace diceGame;

public class Inventory
{
    public IItem[] AllItems =
    {
        new SmallPotion(),
        new MediumPotion(),
        new GoldenFonduePizza(),
        new PotionOfRegenaration()

    }; 
    public IWeapon[] AllWeapons =
    {
        new NoWeapon(),
        new CopperShortSword(),
        new IronSword(),
        new Bow(),
        new PoisenCrossbow(),
        new Shovel()
    };

    public void OpenInventory(Player player)
    {

        var notEmptyItems = AllItems.Where(item => item.Amount > 0).ToList();
        foreach (var Items in notEmptyItems)
        {
            Console.WriteLine($"|{Items} x {Items.Amount} |");
        }
        Console.WriteLine("press X to go back\n press E to equip a different Weapon");
        string input = Console.ReadLine();
        
        if (input != null && input.ToLower() == "x") return;

        if (input != null && input.ToLower() == "e")
        {
            var ownedWeapons = AllWeapons.Where(Weapon => Weapon.Amount >0).ToList();
            foreach (var Weapon in ownedWeapons)
            {
                Console.WriteLine($"|{Weapon} |");
            }
            Console.WriteLine("Input the Nuber from the Weapon to equip it\n or press x to go back");
            string weaponinput = Console.ReadLine();

            if (input != null && input.ToLower() == "x") OpenInventory(player);

            if (int.TryParse(weaponinput, out int parsedInput2))
            {
                var weapon = AllWeapons.FirstOrDefault(weapon => weapon.Id == ownedWeapons[parsedInput2-1].Id);
                player.Weapon = weapon;
                Console.WriteLine($"{player.Name} equiped {weapon}!");
                OpenInventory(player);
            }

            else 
            {
                Console.WriteLine("Invalid Input");
                OpenInventory(player);
            }
       }

        if (int.TryParse(input, out int parsedInput))
        {
            notEmptyItems[parsedInput-1].UseItem(player);
            Console.WriteLine($"{player.Name} used {notEmptyItems[parsedInput-1]}");
        }

        else 
        {
            Console.WriteLine("Invalid Input");
            OpenInventory(player);
        }
    }

    public void GainItem(string itemId, int amount)
    {
        var item = AllItems.FirstOrDefault(item => item.Id == itemId);
        item.Amount+= amount;
    }

    public void GainWeapon(string itemId)
    {
        var weapon = AllWeapons.FirstOrDefault(weapon => weapon.Id == itemId);
        weapon.Amount++;
    }

    public void GainStartEquip()
    {
        //Items
        GainItem("SmallPotion", 1);
        GainItem("MediumPotion", 1);
        GainItem("PotionOfRegenaration", 1);
        //Weapons
        GainWeapon("CopperShortSword");
        GainWeapon("NoWeapon");
    }
}