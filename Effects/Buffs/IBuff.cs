namespace diceGame.Effects.Buffs;

public interface IBuff 
{
    public static abstract string Buff(IFighter user, int Level, int duration);
}