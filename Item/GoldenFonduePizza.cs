namespace diceGame.Item;

using diceGame;

public class GoldenFonduePizza : IItem
{

    private double Health = 35;
    public void UseItem(IFighter user)
    {
        user.Health += Health;
    }

    public override string ToString()
    {
        return "GoldenFonduePizza";
    }
}