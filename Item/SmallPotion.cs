namespace diceGame.Item;

using diceGame;

public class SmallPotion : IItem
{

    private double Health = 15;
    public void UseItem(Player user)
    {
        user.Health += Health;
        if (user.Health > user.MaxHealth) user.Health = user.MaxHealth;
        user.Inventory.SmallPotion.Item1--;
    }

    public override string ToString()
    {
        return "Small Potion";
    }
}
