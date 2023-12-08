namespace diceGame.Item;

using diceGame;

public class GoldenFonduePizza : BaseItem ,IItem
{
    public GoldenFonduePizza()
    {
        Id = "GoldenFonduePizza";
    }
    
    private double Health = 35;
    public void UseItem(Player user)
    {
        user.Health.Current += Health;
        Amount--;
    }

    public override string ToString()
    {
        return "GoldenFonduePizza";
    }
}