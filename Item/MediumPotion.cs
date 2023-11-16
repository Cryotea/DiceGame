
using diceGame;

namespace diceGame.Item;
public class MediumPotion : IItem
{

    private double Health = 30;
    public void UseItem(Player user)
    {
        user.Health += Health;
        if (user.Health > user.MaxHealth) user.Health = user.MaxHealth;
        user.Inventory.MediumPotion.Item1--;
    }

    public override string ToString()
    {
        return "Medium Potion";
    }
}