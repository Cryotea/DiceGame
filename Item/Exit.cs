using diceGame.Weapon;

namespace diceGame.Item;

public class Exit : IItem, IWeapon, IShopItem
{

    public int BuyPrice { get; set; } = 0;
    public int Amount { get; set; } = 1;
    public string Id { get; set; } = "Exit";
    double IItem.Amount { get; set; } = 1;
    public string AttackPattern(IFighter attacker, IFighter defender)
    {
        throw new NotImplementedException();
    }
    
    public void UseItem(Player user)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return "[red]Exit[/]";
    }
}