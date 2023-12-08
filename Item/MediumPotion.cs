
using diceGame;

namespace diceGame.Item;
public class MediumPotion : BaseItem, IItem
{
    public MediumPotion()
    {
        Id = "MediumPotion";
    }
    
    
    private double Health = 30;
    public void UseItem(Player user)
    {
        user.Health.Current += Health;
        if (user.Health.Current > user.Health.Max) user.Health.Current = user.Health.Max;
        Amount--;
    }

    public override string ToString()
    {
        return "Medium Potion";
    }
}