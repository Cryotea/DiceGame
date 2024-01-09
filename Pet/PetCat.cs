using Spectre.Console;

namespace diceGame.Pet;

public class PetCat: IPet
{
    public string Name { get; set; } = $"{ColorManager.BasicPetColor}Cat[/]";
    
    public string Id { get; set; } = "PetCat";

    public string PetAction(Player player, IFighter enemy)
    {
        var random = new Random();
        int attackoption = random.Next(1, 4);

        switch (attackoption)
        {
            case 1 :
                enemy.Health.Current = enemy.Health.Current - player.Speed.Current;
                return $"The {ColorManager.BasicPetColor}Cat[/] Attacked with its claws for [red]{player.Speed.Current} Damage[/]!";
                
            case 2 :
                player.Health.Current += player.Health.Max * 0.1;
                if (player.Health.Current > player.Health.Max) player.Health.Current = player.Health.Max;
                return $"The {ColorManager.BasicPetColor}Cat [/] Healed {player.Name} for {player.Health.Max * 0.1}";
                
            default:
                return $"The {ColorManager.BasicPetColor}Cat[/] is eppy";
            
        }

        
    }
    
    public string GetPet(Player player)
    {
        var PetChoice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title($"A {ColorManager.BasicPetColor}Cat[/] Crossed Ways with you, do you want to take it with you?\nThis replaces you're current pet if you have one.")
                .PageSize(10)
                .AddChoices(new[] {
                    "Yes", "No"
                }));
        if (PetChoice == "Yes")
        {
            player.Pet = new PetCat();
            return $"{player.Name} now has a {ColorManager.BasicPetColor}Cat[/] following them.";
        }

        return $"{player.Name} let the{ColorManager.BasicPetColor} Cat[/] to be on its own little adventure";
    }

}