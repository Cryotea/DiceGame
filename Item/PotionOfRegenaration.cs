using System.Security.Cryptography.X509Certificates;

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
        Console.WriteLine($"{user.Name} has Regenaration for {RegenarationDuration} turns!");
    }

    public override string ToString()
    {
        return "PotionOfRegenaration";
    }
}