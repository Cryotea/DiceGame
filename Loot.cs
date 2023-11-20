
using diceGame.Item;
using diceGame;
using diceGame.Weapon;
namespace diceGame;


public class Loot
{

    public void GetLoot(Player player, IFighter enemy)
    {
        var random = new Random();
        int Loot = random.Next(1,3);
        int RareLootChance = random.Next(1,5);
        int WeaponDropChance = random.Next(1,4);
        
        //use switchcases instead of if
        if(Loot == 1)
        {
            player.Inventory.SmallPotion.Item1 ++;
            Console.WriteLine($"{player.Name} got a {player.Inventory.SmallPotion.Item2}");
        }
        if(Loot == 2)
        {
            player.Inventory.MediumPotion.Item1++;
            Console.WriteLine($"{player.Name} got a {player.Inventory.MediumPotion.Item2}");
        }

        if (RareLootChance == 1)
        {
            int RareLoot = random.Next(1,2);

            if (RareLoot == 1)
            {
                player.Inventory.GoldenFonduePizza.Item1++;
                Console.WriteLine($"{player.Name} got a {player.Inventory.GoldenFonduePizza.Item2}");
            }
        }

        if (WeaponDropChance == 1)
        {
            enemy.Weapon.Loot(player);
        }
    }
/*        public void GetLoot(IFighter enemy, Player player)
    {
        (int, IItem)[] LootPool;
        (int, IItem)[] RareLootPool;
        (int, IWeapon)[] PlayerWeapons;
        LootPool = new (int , IItem)[]
        {
            player.Inventory.SmallPotion,
            player.Inventory.MediumPotion,
        };
        RareLootPool = new (int, IItem)[]
        {
            player.Inventory.GoldenFonduePizza,
        };
        PlayerWeapons = new (int, IWeapon)[]
        {
            player.Inventory.NoWeapon,
            player.Inventory.CopperShortSword,
            player.Inventory.IronSword,
            player.Inventory.Bow,
        };

       var random = new Random();
       int RareDrop = random.Next(1,5);
       int WeaponDrop = random.Next (1,5);

       if (RareDrop == 1)
       {
        int RareLoot = random.Next(0, RareLootPool.Length);
        RareLootPool[RareLoot].Item1++;
        Console.WriteLine($"{player.Name} got {RareLootPool[RareLoot].Item2}");
       }

       if(WeaponDrop == 1)
       {

       }

       int loot = random.Next(0, LootPool.Length) ;
       LootPool[loot].Item1++;
       Console.WriteLine($"{player.Name} got { LootPool[loot].Item2}");
    }
    */
}