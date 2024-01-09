namespace diceGame.Pet;

public class GetRandomPet
{

    private (IPet, bool)[] _allRandomPets =
    {
        (new PetPotato(), false),
        (new PetCat(), false) 
    };

    public string? RandomPet(Player player)
    {
        var random = new Random();
        int PetPicker = random.Next(0, _allRandomPets.Length);

        if (_allRandomPets[PetPicker].Item2 == false)
        {
            _allRandomPets[PetPicker].Item2 = true;
            return _allRandomPets[PetPicker].Item1.GetPet(player);
        }

        else
        {
            return null;
        }
    }
}