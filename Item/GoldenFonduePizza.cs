namespace diceGame.Item;

using diceGame;

public class GoldenFonduePizza : IItem
{

    private double Health = 35;
    public void UseItem(Player user)
    {
        user.Health += Health;
        user.Inventory.GoldenFonduePizza.Item1--;
    }

    public override string ToString()
    {
        return "GoldenFonduePizza";
    }
}