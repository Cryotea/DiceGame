namespace diceGame.Effects.Debuffs;

public interface IDebuff 
{
    public static abstract void Debuff(IFighter user, int Level, int duration);
}