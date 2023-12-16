namespace diceGame.Weapon;

public interface IWeapon
    {
        public int Amount {get; set;}
        public string Id {get; set;}
        public string AttackPattern(IFighter attacker, IFighter defender);
    }
