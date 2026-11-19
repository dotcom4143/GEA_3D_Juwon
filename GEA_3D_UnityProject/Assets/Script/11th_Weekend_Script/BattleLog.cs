using System.Collections.Generic;
using UnityEngine;

public class BattleLog : MonoBehaviour
{
    public int[] damages = { 1200, 3500, 800, 12000, 3500, 950 };
    public int criticalLine = 3000;

    [ContextMenu("전투 기록")]
    void ShowBattleLog()
    {
        int totalDamage = 0;
        List<int> criticals = new List<int>();

        int maxDamage = 0;
        int maxAttackOrder = 0;
        int currentAttackOrder = 0;

        int currentStreak = 0;
        int maxStreak = 0;

        foreach (int dmg in damages)
        {
            currentAttackOrder++;
            totalDamage += dmg;

            if (currentAttackOrder == 1 || dmg > maxDamage)
            {
                maxDamage = dmg;
                maxAttackOrder = currentAttackOrder;
            }

            if (dmg >= criticalLine)
            {
                criticals.Add(dmg);
                currentStreak++;

                if (currentStreak > maxStreak)
                {
                    maxStreak = currentStreak;
                }
            }
            else
            {
                currentStreak = 0;
            }
        }

        Debug.Log("총 데미지 : " + totalDamage);
        Debug.Log("치명타 : " + criticals.Count + " 회");

        if (criticals.Count == 0)
        {
            Debug.Log("치명타 목록 : 없음");
        }
        else
        {
            string critText = "치명타 목록 : ";
            int index = 0;

            foreach (int crit in criticals)
            {
                if (index > 0)
                {
                    critText += ", ";
                }
                critText += crit;
                index++;
            }

            Debug.Log(critText);
        }

        if (damages.Length == 0)
        {
            Debug.Log("최고 데미지 : 0 (기록 없음)");
        }
        else
        {
            Debug.Log("최고 데미지 : " + maxDamage + " (" + maxAttackOrder + " 번째 공격)");
        }

        Debug.Log("최대 연속 치명타 : " + maxStreak + " 회");
    }
}