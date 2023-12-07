
using diceGame;

namespace diceGame.Item;
public class MediumPotion : IItem
{
    public string Id {get; set;} = "MediumPotion";
    public int Amount {get; set;} 
    private double Health = 30;
    public void UseItem(Player user)
    {
        user.Health.HP += Health;
        if (user.Health.HP > user.Health.MaxHealth) user.Health.HP = user.Health.MaxHealth;
        Amount--;
    }

    public override string ToString()
    {
        return "Medium Potion";
    }
}