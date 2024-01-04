using diceGame.Pet;
using Spectre.Console;

namespace diceGame;

public class EventManager
{
    private Shop _shop = new Shop();
    public void RandomEvent(Player player, Log log)
    {

        if (log.Fights % 4 == 0 && log.Fights > 0)
        {
            var openshop = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("you found a Shop! do you want to enter it?")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
                    .AddChoices(new[] {
                        "yes", "no",
                    }));
            if (openshop == "yes")_shop.OpenShop(player, log);
        }
        
        if (log.DefeatedEnemies[0].Item2 == 2 && log.DefeatedEnemies[4].Item2 == 1)
        {
            var answer = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title($"{player.Name} found a SmallSlime, it wants to join them.\n do you accept?")
                    .PageSize(10)
                    .AddChoices(new[] {
                        "Yes", "No"
                    }));

            if (answer == "Yes")player.Pet = new PetSlime();
            
        }
        
    }
}