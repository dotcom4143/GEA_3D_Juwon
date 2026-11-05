using UnityEngine;

public class RewardCalculator : MonoBehaviour
{
    public int playSeconds = 3725;
    public int gold = 1234;
    public int members = 4;
    public int kills = 7;
    public int expPerKill = 35;
    public int totalDamage = 250;
    public int hits = 20;

    public float expRate = 1.5f;
    
    [ContextMenu("골드 출력")]
    void Debuglog()
    {
        // 플탐
        int totalSec = (int)playSeconds;

        int TimeHour = (totalSec / 3600);
        int TimeMin = ((totalSec % 3600) / 60);
        int TimeSec = totalSec % 60;
        Debug.Log(TimeHour+":"+TimeMin+":"+TimeSec);


        //골드 분배
        int Total = Totalgold/ 
    }


}
