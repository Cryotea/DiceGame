using diceGame.Item;
using diceGame.Weapon;

namespace diceGame;

public class Inventory
{
    // normal Items
    public (int, IItem) SmallPotion = (1, new SmallPotion());
    public (int, IItem) MediumPotion = (1, new MediumPotion());
    public (int, IItem) PotionOfRegenaration = (1, new PotionOfRegenaration());

    // rare Items
    public (int, IItem) GoldenFonduePizza = (0, new GoldenFonduePizza());

    // Weapons
    public (int, IWeapon) NoWeapon = (1, new NoWeapon());
    public (int, IWeapon) CopperShortSword = (1, new CopperShortSword());
    public (int, IWeapon) IronSword = (0, new IronSword());
    public (int, IWeapon) Bow = (0, new Bow()); 
    public (int, IWeapon) PoisenCrossbow = (0, new PoisenCrossbow());

    public void OpenInventory(Player player)
    {
        (int, IItem)[] AllItems;
        (int, IWeapon)[] AllWeapons;
        
        AllItems = new (int, IItem)[]
        {
            SmallPotion,
            MediumPotion,
            GoldenFonduePizza,
            PotionOfRegenaration
        };

         AllWeapons = new (int, IWeapon)[]
        {
            NoWeapon,
            CopperShortSword,
            IronSword,
            Bow,
            PoisenCrossbow
        };

        var notEmptyItems = AllItems.Where(item => item.Item1 > 0).ToList();
        foreach (var Items in notEmptyItems)
        {
            Console.WriteLine($"|{Items.Item2} x {Items.Item1} |");
        }
        Console.WriteLine("press X to go back\n press E to equip a different Weapon");
        string input = Console.ReadLine();
        
        if (input != null && input.ToLower() == "x") return;

        if (input != null && input.ToLower() == "e")
        {
            var ownedWeapons = AllWeapons.Where(Weapon => Weapon.Item1 >0).ToList();
            foreach (var Weapon in ownedWeapons)
            {
                Console.WriteLine($"|{Weapon.Item2} |");
            }
            Console.WriteLine("Input the Nuber from the Weapon to equip it\n or press x to go back");
            string weaponinput = Console.ReadLine();

            if (input != null && input.ToLower() == "x") OpenInventory(player);

             if (int.TryParse(weaponinput, out int parsedInput2))
            {
                ownedWeapons[parsedInput2-1].Item2.EquipWeapon(player);
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
            notEmptyItems[parsedInput-1].Item2.UseItem(player);
            Console.WriteLine($"{player.Name} used {notEmptyItems[parsedInput-1].Item2}");
        }

        else 
        {
            Console.WriteLine("Invalid Input");
            OpenInventory(player);
        }
    }
}