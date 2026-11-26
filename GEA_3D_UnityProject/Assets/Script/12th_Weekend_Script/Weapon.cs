public class Weapon
{
    public string name;
    public int durability;
    public int maxDurability;

    public Weapon(string name)
    {
        this.name = name;
        this.durability = 5;
        this.maxDurability = 5;
    }

    public Weapon(string name, int durability)
    {
        this.name = name;
        this.durability = durability;
        this.maxDurability = durability;
    }

    public bool Use()
    {
        if (durability <= 0) return false;
        durability--;
        return true;
    }

    public bool Repair()
    {
        if (durability <= 0 || durability >= maxDurability) return false;
        durability++;
        return true;
    }
}