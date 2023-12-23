using diceGame.Enemy;

namespace diceGame.Pet;

public class PetSlime : IPet
{
    public string Name { get; set; } = $"{ColorManager.BasicPetColor}SmallSlime[/]";

    public string Id { get; set; } = "PetSlime";

    public string PetAction(Player player, IFighter enemy)
    {
        double DamageDone = Math.Round(player.Health.Current * 0.2);
        enemy.Health.Current = Math.Round(enemy.Health.Current - DamageDone);
        return ($"{player.Name}'s {Name} attacked {enemy.Name} for {DamageDone}! {enemy.Name} has {enemy.Health.Current} HP left!");
    }
}