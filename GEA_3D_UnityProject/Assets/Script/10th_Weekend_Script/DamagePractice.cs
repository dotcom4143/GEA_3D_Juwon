using UnityEngine;

public class DamagePractice : MonoBehaviour
{
    [SerializeField] public int attack;
    [SerializeField] public int defense;

    [SerializeField] public bool isCritical;
    [SerializeField] public bool targetIsBoss;


    [ContextMenu("데미지")]
    void emotinaldamage()
    {
        int damage = attack - defense;

        if (damage < 1)
        {
            damage = 1;
        }
        if (isCritical== true)
        {
            damage = damage * 2;
        }

        if (targetIsBoss == true)
        {
            damage = damage / 2;
        }

        if (targetIsBoss == false)
        {
            damage = damage * 2;
        }

        Debug.Log(damage);
    }
}
