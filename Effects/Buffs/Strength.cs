using diceGame.Effects.Buffs;

namespace diceGame.Effects;

public class Strength : IBuff
{
    public static string Buff(IFighter user, int Level, int duration)
    {
        return "test";
    }
}