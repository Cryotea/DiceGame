
using diceGame;

namespace diceGame.Item;
public class MediumPotion : IItem
{
    public string Id {get; set;} = "MediumPotion";
    public int Amount {get; set;} 
    private double Health = 30;
    public void UseItem(Player user)
    {
        user.Health += Health;
        if (user.Health > user.MaxHealth) user.Health = user.MaxHealth;
        Amount--;
    }

    public override string ToString()
    {
        return "Medium Potion";
    }
}