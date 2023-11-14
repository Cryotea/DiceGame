namespace diceGame.Item;

using diceGame;

public class MediumPotion : IItem
{

    private double Health = 30;
    public void UseItem(IFighter user)
    {
        user.Health += Health;
        if (user.Health > user.MaxHealth) user.Health = user.MaxHealth;
    }

    public override string ToString()
    {
        return "Medium Potion";
    }
}