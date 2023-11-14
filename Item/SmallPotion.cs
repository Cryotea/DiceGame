namespace diceGame.Item;

using diceGame;

public class SmallPotion : IItem
{

    private double Health = 15;
    public void UseItem(IFighter user)
    {
        user.Health += Health;
        if (user.Health > user.MaxHealth) user.Health = user.MaxHealth;
    }

    public override string ToString()
    {
        return "Small Potion";
    }
}
