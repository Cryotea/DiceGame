using diceGame.Pet;
using Spectre.Console;

namespace diceGame;

public class EventManager
{
    public void RandomEvent(Player player, Log log)
    {
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