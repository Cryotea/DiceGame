namespace diceGame.Item;

using diceGame;

public class GoldenFonduePizza : IItem
{
    public string Id {get; set;} = "GoldenFonduePizza";
    public int Amount {get; set;} 
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