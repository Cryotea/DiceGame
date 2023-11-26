namespace diceGame.Item;

using diceGame;

public interface IItem
{
    public string Id {get; set;}
    public int Amount {get; set;} 
    public void UseItem(Player user);

}