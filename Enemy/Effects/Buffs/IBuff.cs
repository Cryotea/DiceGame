namespace diceGame.Effects.Buffs;

public interface IBuff 
{
    public static void Buff(IFighter user, int Level, int duration);
}