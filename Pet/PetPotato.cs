using Spectre.Console;

namespace diceGame.Pet;

public class PetPotato :IPet
{
    public string Name { get; set; } = $"{ColorManager.BasicPetColor}PetPotato[/]";

    public string Id { get; set; } = "PetPotato";

    public string PetAction(Player player, IFighter enemy)
    {
        var random = new Random();
        double attackChance = random.Next(1, 101);

        if (attackChance >= 95)
        {
            enemy.Health.Current = enemy.Health.Current - 99_999_999;
            return $"{ColorManager.BasicPetColor}Potato[/] shot a DEATHRAY and damaged {enemy.Name} for [red]99999999 Damage[/]!? ";
        }

        return $"The {ColorManager.BasicPetColor}Potato[/] is looking at you...";


    }
    
    public string GetPet(Player player)
    {
        var PetChoice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title($"You Found a {ColorManager.BasicPetColor}Potato[/]... It wants to join you very much \nWhat do you think?\nThis replaces you're current pet if you have one.")
                .PageSize(10)
                .AddChoices(new[] {
                    "Sure", "Nuh uh"
                }));
        if (PetChoice == "Sure")
        {
            player.Pet = new PetPotato();
            return $"{player.Name} now has a {ColorManager.BasicPetColor}Potato[/] as a Pet, [red]HELL YEAH![/]";
        }

        return $"{player.Name} has denied the {ColorManager.BasicPetColor}Potato[/] true Companionship , you are a [red]monster[/]...";
    }
    
    
}