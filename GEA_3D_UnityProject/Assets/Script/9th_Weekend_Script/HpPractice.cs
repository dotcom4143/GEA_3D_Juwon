using UnityEngine;

public class HpPractice : MonoBehaviour
{
    int currentHp = 0;
    int maxHp = 0;


    [ContextMenu("체력")]
    void DebugHp()
    {
        // 출력 1번 70%
        currentHp = 7;
        maxHp = 10;

        int a = (currentHp * 100 / maxHp);
        Debug.Log("HP : " + a + "%");

        // 출력 2번 70%

        currentHp = 1;
        maxHp = 3;

        int b = (currentHp * 100 / maxHp);
        Debug.Log("HP : " + b + "%");

        // 출력 3번 70%

        currentHp = 10;
        maxHp = 10;

        int c = (currentHp * 100 / maxHp);
        Debug.Log("HP : " + c + "%");

        // 출력 4번 70%

        currentHp = 0;
        maxHp = 10;

        int d = (currentHp * 100 / maxHp);
        Debug.Log("HP : " + d + "%");

    }
}
