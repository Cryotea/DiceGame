namespace diceGame.Weapon;

public interface IWeapon
    {
        public void AttackPattern(IFighter attacker, IFighter defender);
        public void EquipWeapon(Player player);
        public void Loot(Player player);
    }
