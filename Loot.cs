
using diceGame.Item;
using diceGame;
using diceGame.Weapon;
using diceGame.Enemy;
namespace diceGame;


public class Loot
{

    public void GetLoot(Player player, IEnemy enemy)
    {
       enemy.LootTable.GetLootTableItems(player);
       enemy.LootTable.GetWeaponDrop(player, enemy);
       enemy.GetStats(player);
       enemy.GetExp(player);
    }

}