namespace diceGame.Item;

public class PotionOfRegenaration : IItem
{
    public string Id {get; set;} = "PotionOfRegenaration";
    public int Amount {get; set;} 
    private int RegenarationLevel = 2;
    private int RegenarationDuration = 3;

    public void UseItem(Player user)
    {
        user.Effect.Regenaration.Item1 = RegenarationLevel;
        user.Effect.Regenaration.Item2 = RegenarationDuration;
        Amount--;
        Console.WriteLine($"{user.Name} has Regenaration for {RegenarationDuration} turns!");
    }

    public override string ToString()
    {
        return "PotionOfRegenaration";
    }
}