using UnityEngine;

public class ClassPractice : MonoBehaviour
{
    Weapon sword = new Weapon("낡은 검");

    [ContextMenu("클래스 실습")]
    void WeaponUse()
    {
        if (sword.Use())
        {
            Debug.Log(sword.name + " 사용, 남은 내구도 " + sword.durability);
        }
        else
        {
            Debug.Log(sword.name + " 쨍그랑!! (무기 깨져서 갸루쿡으로 변한 소리).");
        }
    }
    
    // 추가 응용 

    [ContextMenu("클래스 추가 응용")]
    void WeaponRepair()
    {
        if (sword.Repair())
        {
            Debug.Log(sword.name + " 수리, 남은 내구도 " + sword.durability);
        }
        else
        {
            if (sword.durability <= 0)
            {
                Debug.Log("무기가 파괴 되어 있어 수리할 수 없습니다.");
            }
            else
            {
                Debug.Log(sword.name + " 이미 최대 내구도입니다.");
            }
        }
    }
}