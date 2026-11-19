using UnityEngine;
using System.Collections.Generic;

public class DoreachPracticex: MonoBehaviour
{
       public int[] monsterHp = { 0, 35, 0, 80, 12 };
 
    [ContextMenu("foreach 실습")]
    void CountingMonster()
    {
        int aliveCount = 0;
        int hpTotal = 0;
        foreach (int hp in monsterHp)
        {

            if (hp >= 0)
            {
                aliveCount++;
                hpTotal += hp;
            }
        }
        Debug.Log("살아 있는 몬스터 : " + aliveCount + " 마리");
        Debug.Log("남은 체력 합 : " + hpTotal);
    }
}
