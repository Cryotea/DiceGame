using diceGame.Enemy;

namespace diceGame.Pet;

public interface IPet
{
    public string Name { get; set; }
    
    public string Id { get; set; }
    
    public string PetAction(Player player, IFighter enemy);
    
    
}