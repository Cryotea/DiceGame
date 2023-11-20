namespace diceGame.Item;

public class PotionOfRegenaration : IItem
{
    private int RegenarationLevel = 2;
    private int RegenarationDuration = 3;

    public void UseItem(Player user)
    {
        user.Effect.Regenaration.Item1 = RegenarationLevel;
        user.Effect.Regenaration.Item2 = RegenarationDuration;
        user.Inventory.PotionOfRegenaration.Item1--;
        Console.WriteLine($"{user.Name} has Regenaration for {RegenarationDuration} turns!");
    }

    public override string ToString()
    {
        return "PotionOfRegenaration";
    }
}