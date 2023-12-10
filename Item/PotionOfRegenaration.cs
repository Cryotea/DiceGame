using Spectre.Console;
namespace diceGame.Item;

public class PotionOfRegenaration : BaseItem, IItem
{
    public PotionOfRegenaration()
    {
        Id = "PotionOfRegenaration";
    }
    
    private int RegenarationLevel = 2;
    private int RegenarationDuration = 3;

    public void UseItem(Player user)
    {
        user.Effect.Regenaration.Item1 = RegenarationLevel;
        user.Effect.Regenaration.Item2 = RegenarationDuration;
        Amount--;
        AnsiConsole.MarkupLine($"{user.Name} has Regeneration for {RegenarationDuration} turns!");
    }

    public override string ToString()
    {
        return $"{Color}PotionOfRegeneration[/]";
    }
}