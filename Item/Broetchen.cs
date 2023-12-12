// I love Teddy<3

namespace diceGame.Item;

public class Broetchen : BaseItem, IItem
{
    public Broetchen()
    {
        Id = "Broetchen";
    }
    
    private double Health = 100;
    public void UseItem(Player user)
    {
        user.Health.Current += Health;
        Amount--;
    }

    public override string ToString()
    {
        return $"{Color}Brötchen[/]";
    }
}