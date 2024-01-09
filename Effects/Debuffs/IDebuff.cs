namespace diceGame.Effects.Debuffs;

public interface IDebuff 
{
    public static abstract string Debuff(IFighter user, int Level, int duration);
}