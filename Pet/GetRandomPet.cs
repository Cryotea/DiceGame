namespace diceGame.Pet;

public class GetRandomPet
{

    private IPet[] _allRandomPets =
    {
        new PetPotato(),
        new PetCat()
    };

    public string? RandomPet(Player player)
    {
        var random = new Random();
        int PetPicker = random.Next(0, _allRandomPets.Length);

       return _allRandomPets[PetPicker].GetPet(player);
    }
}