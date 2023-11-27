namespace diceGame.Weapon;

public interface IWeapon
    {
        public int Amount {get; set;}
        public string Id {get; set;}
        public void AttackPattern(IFighter attacker, IFighter defender);
        public void EquipWeapon(Player player);
    }
