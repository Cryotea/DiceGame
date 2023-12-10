using diceGame.Item;
using diceGame.Weapon;
using Spectre.Console;

namespace diceGame;

public class Shop
{
    //items
    public (int, IItem) SmallPotion = (5, new SmallPotion());
    public (int, IItem) MediumPotion = (10, new MediumPotion());
    public (int, IItem) PotionOfRegenaration = (5, new PotionOfRegenaration());

    //Weapons
    public (int, IWeapon) Shovel = (20, new Shovel());

    public void OpenShop(Player player)
    {
        (int, IItem)[] BuyItems;
        int Counter = 1;
        BuyItems = new (int, IItem)[]
        {
            SmallPotion,
            MediumPotion,
            PotionOfRegenaration
        };

        AnsiConsole.MarkupLine("Welcome to the shope, Enter the number next to the Item to Item to buy it. \n press x to exit the shop. ");
        foreach(var Item in BuyItems)
        {
            AnsiConsole.MarkupLine($"{Counter}.{Item.Item2} for {Item.Item2}$ !");
            Counter++;
        }
        string input = Console.ReadLine();

        if (input != null && input.ToLower() == "x") return;

        if (int.TryParse(input, out int parsedInput))
        {

        }    
    }
}