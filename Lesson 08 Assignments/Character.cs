public class Character
{

    public string Name { get; set; }
    public int Health { get; set; }
    public List<Weapon> Weapons { get; set; } = new List<Weapon>();

    public void Hit(Weapon weapon, Character target)
    {
        int damageDealt = weapon.GiveDamage(weapon.Damage);
        target.TakeDamage(damageDealt);

    }

    public void TakeDamage(int damage)
    {

        Health -= damage;

    }

}
