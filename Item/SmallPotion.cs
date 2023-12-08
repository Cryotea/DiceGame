namespace diceGame.Item;

using diceGame;

public class SmallPotion : IItem
{
    public string Id {get; set;} = "SmallPotion";
    public int Amount {get; set;} 
    private double Health = 15;
    public void UseItem(Player user)
    {
        user.Health.Current += Health;
        if (user.Health.Current > user.Health.Max) user.Health.Current = user.Health.Max;
        Amount--;
    }

    public override string ToString()
    {
        return "Small Potion";
    }
}
