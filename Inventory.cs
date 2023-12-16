using diceGame.Effects.Debuffs;
using diceGame.Item;
using diceGame.Weapon;
using Spectre.Console;

namespace diceGame;

public class Inventory
{
    public IItem[] AllItems =
    {
        new SmallPotion(),
        new MediumPotion(),
        new GoldenFonduePizza(),
        new PotionOfRegenaration(),
        new Broetchen(),
        new Exit()

    }; 
    public IWeapon[] AllWeapons =
    {
        new NoWeapon(),
        new CopperShortSword(),
        new IronSword(),
        new Bow(),
        new PoisenCrossbow(),
        new Shovel(),
        new Exit()
    };

    public void OpenInventory(Player player, Log log)
    {
        var InventorySeletion= AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("[darkorange]Weapons[/] or [lightgoldenrod1]Items[/]?")
                .PageSize(10)
                .MoreChoicesText("(Move up and down to reveal more [darkorange]Weapons)[/]")
                .AddChoices(new[] {
                    "[darkorange]Weapons[/]","[lightgoldenrod1]Items[/]"
                }));

        if (InventorySeletion == "[lightgoldenrod1]Items[/]" )
        {
            var notEmptyItems = AllItems.Where(item => item.Amount > 0).ToList();
       
            var ItemSelection = AnsiConsole.Prompt(
                new SelectionPrompt<IItem>()
                    .Title("What [lightgoldenrod1]Item[/] do you want to use?")
                    .PageSize(10)
                    .MoreChoicesText("Move up and down to see more [lightgoldenrod1]Items[/]")
                    .AddChoices(notEmptyItems
                    
                    ).UseConverter((item => item.ToString() )));



            if (ItemSelection.Id == "Exit")
            {
                AnsiConsole.Clear();
                log.WriteTwoLatestMessage();
                return;
            }
            
            ItemSelection.UseItem(player);
            AnsiConsole.Clear();
            log.AddMessage($"\n{player.Name} used {ItemSelection}");
            log.WriteTwoLatestMessage();
            
            
        }

        if (InventorySeletion == "[darkorange]Weapons[/]" )
        {
            var ownedWeapons = AllWeapons.Where(Weapon => Weapon.Amount >0).ToList();
            
            var WeaponSelection = AnsiConsole.Prompt(
                new SelectionPrompt<IWeapon>()
                    .Title("What [lightgoldenrod1]Item[/] do you want to use?")
                    .PageSize(10)
                    .MoreChoicesText("Move up and down to see more [lightgoldenrod1]Items[/]")
                    .AddChoices(ownedWeapons
                    
                    ).UseConverter((item => item.ToString() )));

            if (WeaponSelection.Id == "Exit")
            {
                AnsiConsole.Clear();
                log.WriteTwoLatestMessage();
                return;
            }

            
                var weapon = AllWeapons.FirstOrDefault(weapon => weapon.Id == WeaponSelection.Id);
                player.Weapon = weapon;
                AnsiConsole.Clear();
                log.AddMessage($"\n{player.Name} equiped {weapon}!");
                log.WriteTwoLatestMessage();
                return;
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
        GainItem("Broetchen", 1);
        //Weapons
        GainWeapon("CopperShortSword");
        GainWeapon("NoWeapon");
    }
}