namespace diceGame.Enemy;

public interface IEnemy : IFighter, ICloneable
{
    public void GetStats(Player player);
}