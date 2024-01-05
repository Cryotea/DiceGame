using diceGame.Item;
using diceGame.Weapon;
using Spectre.Console;

namespace diceGame;

public class Shop
{
    public IShopItem[] AllShopItems =
    {
        new SmallPotion(),
        new MediumPotion(),
        new PotionOfRegenaration(),

        new Shovel(),

        new Exit()
    };

    public void OpenShop(Player player, Log log)
    {
       

        var BuyOptions = AnsiConsole.Prompt(
            new SelectionPrompt<IShopItem>()
                .Title($"\nWelcome to my Shop! What do you want to buy? \n {player.Name}'s {ColorManager.MoneyColor} Money : {player.Money}$ [/]")
                .PageSize(10)
                .AddChoices(AllShopItems)
                .UseConverter(item => item.Id == "Exit" ? item.ToString()! : $"{item} for {ColorManager.MoneyColor}{item.BuyPrice}$[/]"));

        if (BuyOptions.Id == "Exit")
        {
            AnsiConsole.Clear();
            return;
        }

        switch (BuyOptions.BuyPrice < player.Money)
        {
            case true:
                var BoughtItem = player.Inventory.AllItems.FirstOrDefault(item => item.Id == BuyOptions.Id);
                        if (BoughtItem is not null) BoughtItem.Amount++;
                        
                        var BoughtWeapons = player.Inventory.AllWeapons.FirstOrDefault(item => item.Id == BuyOptions.Id);
                        if (BoughtWeapons is not null) BoughtWeapons.Amount++;
                        
                        player.Money -= BuyOptions.BuyPrice;
                
                        AnsiConsole.Clear();
                        log.AddMessage($"\n{player.Name} bought {BuyOptions}");
                        log.WriteTwoLatestMessage();
                        break;
            case false:
                AnsiConsole.Clear();
                log.AddMessage($"{player.Name} does not have enough {ColorManager.MoneyColor}Money[/] ");
                log.WriteTwoLatestMessage();
                break;
        }
        
        OpenShop(player, log);

    }
    
}