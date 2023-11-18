namespace diceGame.Effects.Buffs;

public interface IBuff 
{
    public static abstract void Buff(IFighter user, int Level, int duration);
}