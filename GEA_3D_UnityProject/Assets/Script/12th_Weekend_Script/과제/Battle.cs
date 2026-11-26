using UnityEngine;

public class Battle : MonoBehaviour
{
    public int heroHp = 100;
    public int heroAttack = 30;
    public int heroDefense = 10;

    public int monsterHp = 80;
    public int monsterAttack = 25;
    public int monsterDefense = 5;

    public int[] monsterHps = { 80, 40, 120 };

    void Attack(int turn, Fighter attacker, Fighter target)
    {
        int damage = attacker.GetDamageTo(target);
        target.TakeDamage(damage);
        Debug.Log(turn + " 턴: " + attacker.name + "의 공격 " + damage + ", " + target.name + " 체력 " + target.hp);
    }

    [ContextMenu("전투")]
    void StartBattle()
    {
        Fighter hero = new Fighter("용사", heroHp, heroAttack, heroDefense);
        Fighter monster = new Fighter("슬라임", monsterHp, monsterAttack, monsterDefense);

        int turn = 0;

        while (!hero.IsDead() && !monster.IsDead())
        {
            turn++;
            Attack(turn, hero, monster);

            if (monster.IsDead()) break;

            Attack(turn, monster, hero);
        }

        if (monster.IsDead())
        {
            Debug.Log(hero.name + " 승리 (" + turn + " 턴)");
        }
        else
        {
            Debug.Log(monster.name + " 승리 (" + turn + " 턴)");
        }
    }

    [ContextMenu("연속 전투")]
    void StartChainBattle()
    {
        Fighter hero = new Fighter("용사", heroHp, heroAttack, heroDefense);
        int defeatCount = 0;

        for (int i = 0; i < monsterHps.Length; i++)
        {
            Fighter monster = new Fighter("슬라임", monsterHps[i], monsterAttack, monsterDefense);

            while (!hero.IsDead() && !monster.IsDead())
            {
                monster.TakeDamage(hero.GetDamageTo(monster));
                if (monster.IsDead()) break;

                hero.TakeDamage(monster.GetDamageTo(hero));
            }

            if (monster.IsDead())
            {
                defeatCount++;
                Debug.Log((i + 1) + " 번째 슬라임 처치, 용사 체력 : " + hero.hp);
            }
            else
            {
                Debug.Log((i + 1) + " 번째 슬라임에게 패배");
                break;
            }
        }

        Debug.Log("결과: " + monsterHps.Length + " 마리 중 " + defeatCount + " 마리 처치");
    }

    [ContextMenu("물약 전투")]
    void StartPotionBattle()
    {
        Fighter hero = new Fighter("용사", heroHp, heroAttack, heroDefense);
        Fighter monster = new Fighter("슬라임", monsterHp, monsterAttack, monsterDefense);

        int turn = 0;

        while (!hero.IsDead() && !monster.IsDead())
        {
            turn++;

            if (hero.CanUsePotion())
            {
                hero.UsePotion();
                Debug.Log(turn + " 턴: " + hero.name + "의 물약, " + hero.name + " 체력 " + hero.hp);
            }
            else
            {
                Attack(turn, hero, monster);
            }

            if (monster.IsDead()) break;

            Attack(turn, monster, hero);
        }

        if (monster.IsDead())
        {
            Debug.Log(hero.name + " 승리 (" + turn + " 턴)");
        }
        else
        {
            Debug.Log(monster.name + " 승리 (" + turn + " 턴)");
        }
    }
}