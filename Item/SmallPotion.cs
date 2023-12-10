namespace diceGame.Item;

using diceGame;

public class SmallPotion : BaseItem, IItem
{
    public SmallPotion()
    {
        Id = "SmallPotion";
    }
    
    private double Health = 15;
    public void UseItem(Player user)
    {
        user.Health.Current += Health;
        if (user.Health.Current > user.Health.Max) user.Health.Current = user.Health.Max;
        Amount--;
    }

    public override string ToString()
    {
        return $"{Color}Small Potion[/]";
    }
}
