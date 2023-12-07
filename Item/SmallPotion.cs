namespace diceGame.Item;

using diceGame;

public class SmallPotion : IItem
{
    public string Id {get; set;} = "SmallPotion";
    public int Amount {get; set;} 
    private double Health = 15;
    public void UseItem(Player user)
    {
        user.Health.HP += Health;
        if (user.Health.HP > user.Health.MaxHealth) user.Health.HP = user.Health.MaxHealth;
        Amount--;
    }

    public override string ToString()
    {
        return "Small Potion";
    }
}
