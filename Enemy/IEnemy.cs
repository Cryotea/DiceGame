namespace diceGame.Enemy;

public interface IEnemy : IFighter, ICloneable
{
    public LootTable LootTable {get; set;}
    public void GetStats(Player player);
    public void GetExp(Player player);
    public void GetMoney(Player player);
}