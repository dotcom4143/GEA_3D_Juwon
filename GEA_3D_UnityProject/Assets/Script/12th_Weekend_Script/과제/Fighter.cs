public class Fighter
{
    public string name;
    public int hp;
    public int maxHp;
    public int attack;
    public int defense;
    public int potionCount = 1;

    public Fighter(string name, int hp, int attack, int defense)
    {
        this.name = name;
        this.hp = hp;
        this.maxHp = hp;
        this.attack = attack;
        this.defense = defense;
    }

    public int GetDamageTo(Fighter target)
    {
        int damage = this.attack - target.defense;
        if (damage < 1)
        {
            damage = 1;
        }
        return damage;
    }

    public void TakeDamage(int damage)
    {
        this.hp -= damage;
        if (this.hp < 0)
        {
            this.hp = 0;
        }
    }

    public bool IsDead()
    {
        return this.hp <= 0;
    }

    public bool CanUsePotion()
    {
        return potionCount > 0 && hp <= (maxHp * 0.3f);
    }

    public void UsePotion()
    {
        potionCount--;
        int healAmount = maxHp / 2;
        hp += healAmount;
        if (hp > maxHp)
        {
            hp = maxHp;
        }
    }
}