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

    public (int, IItem) [] ItemList =
    {
       (1, new SmallPotion()),
       (1, new MediumPotion())
    };

/* 
wurde hier gerne die inventory numbers zum auswahlen nicht hard coden
sodass items nicht angezeigt werden wenn man 0 von ihnen hat, meine
idee ware die in einen temporare arry zu tun wenn sie mehr als 0 items
davon habe jedoch weiss ich nicht wie oder ob das geht dabei brauche 
ich deine hilfe
*/
    public void OpenInventory()
    {
        foreach (var Items in ItemList)
        {
            Console.WriteLine($"|{Items.Item2} x {Items.Item1} |");
        }
        Console.WriteLine("press X to go back");
        string input = Console.ReadLine();
        
    }

    public bool PlayerMove(Player player, IFighter enemy, bool usedMove)
    {
        
        Console.WriteLine($"what is {player.Name} doing ");
        Console.WriteLine($"|1 = Attack |2 = Inventory |3 = {player.Name}'s Stats |");
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
        Console.WriteLine($"Name :{Name} \tHP:{Health}/{MaxHealth} \nDMG:{Damage} \tWeapon:{Weapon} \nSpeed:{Speed} \tDefence:{Defence} ");
        Console.WriteLine("press enter to go back");
        Console.ReadLine();
    }

}