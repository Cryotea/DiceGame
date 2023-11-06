namespace diceGame.Weapon;

public interface IWeapon
    {
        public void AttackPattern(IFighter attacker, IFighter defender);
    }
