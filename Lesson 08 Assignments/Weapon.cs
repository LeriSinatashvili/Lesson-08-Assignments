public abstract class Weapon
{

    public string Name { get; set; }
    public int Damage { get; set; }

    public abstract int GiveDamage(int damage);
}
