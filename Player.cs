namespace diceGame;

using diceGame.Item;
using diceGame.Weapon;
using diceGame.Enemy;
public class Player : IFighter
{
    public string Name {get; set;} = "Player";
    public double Health {get; set;} = 20;
    public double Damage {get; set;} = 1;
    public double Speed {get; set;} = 1;
    public double Defence {get; set;} = 1;
    public IWeapon Weapon {get; set;} = new CopperShortSword();
    public double MaxHealth {get; set;} = 20;

    public (int, IItem)[] ItemList =
    {
       (1, new SmallPotion()),
       (1, new MediumPotion()),
       (0, new GoldenFonduePizza())
    };

    public (bool, IWeapon)[] WeaponList =
    {
        (true, new NoWeapon()),
        (true, new CopperShortSword()),
        (false, new IronSword()),
        (false, new Bow())
    };
    public void OpenInventory()
    {
        var notEmptyItems = ItemList.Where(item => item.Item1 > 0).ToList();
        foreach (var Items in notEmptyItems)
        {
            Console.WriteLine($"|{Items.Item2} x {Items.Item1} |");
        }
        Console.WriteLine("press X to go back\n press E to equip a different Weapon");
        string input = Console.ReadLine();
        
        if (input != null && input.ToLower() == "x") return;

        if (input != null && input.ToLower() == "e")OpenWeaponInventory();

        if (int.TryParse(input, out int parsedInput))
        {
            notEmptyItems[parsedInput-1].Item2.UseItem(this);
            var usedItem = notEmptyItems[parsedInput-1];
            int itemNumber = Array.IndexOf(ItemList, usedItem);
            ItemList[itemNumber].Item1--;
            Console.WriteLine($"{this.Name} used {notEmptyItems[parsedInput-1].Item2}");
        }

        else 
        {
            Console.WriteLine("Invalid Input");
            OpenInventory();
        }
        
        
    }

    public void OpenWeaponInventory()
    {
        var ownedWeapons = WeaponList.Where(weapon => weapon.Item1 == true).ToList();
        foreach (var weapon in ownedWeapons)
        {
            Console.WriteLine($"|{weapon.Item2} |");
        }
        Console.WriteLine("press x to go back");
        string input = Console.ReadLine();

        if (input != null && input.ToLower() == "x") return;

        if (int.TryParse(input, out int parsedInput))
        {
            Weapon = ownedWeapons[parsedInput-1].Item2;
            Console.WriteLine($"{this.Name} equiped {ownedWeapons[parsedInput-1].Item2}");
           
        }
        
        else 
        {
            Console.WriteLine("Invalid Input");
            OpenWeaponInventory();
        }
    }
    public bool PlayerMove(Player player, IFighter enemy, bool usedMove)
    {
        
        Console.WriteLine($"what is {player.Name} doing ");
        Console.WriteLine($"|1 = Attack |2 = Inventory |3 = {player.Name}'s Stats ");
        string input = Console.ReadLine();
        if (input == "1")
        {
            player.Weapon.AttackPattern(player, enemy);
            usedMove = true;
            return usedMove;
        }
        if (input == "2")
        {
            player.OpenInventory();
            usedMove = false;
            return usedMove;
        }
        if (input == "3")
        {
            player.ShowStats();
        }
        else Console.WriteLine("Please Input a Valid Number");
        usedMove = false;
        return usedMove;
        
    }

    public void ShowStats()
    {
        Console.WriteLine($"Name :{Name} \tHP:{Health}/{MaxHealth} \nDMG:{Damage} \t\tWeapon:{Weapon} \nSpeed:{Speed} \tDefence:{Defence} ");
        Console.WriteLine("press enter to go back");
        Console.ReadLine();
    }

}