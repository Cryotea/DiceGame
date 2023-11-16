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

    public Inventory Inventory {get; set;} = new Inventory(); 

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
            Inventory.OpenInventory(this);
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