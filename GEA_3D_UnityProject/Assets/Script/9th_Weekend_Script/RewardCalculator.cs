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

        int min10 = TimeMin / 10;
        int min1 = TimeMin % 10;
        int sec10 = TimeSec / 10;
        int sec1 = TimeSec % 10;

        Debug.Log(TimeHour + ":" + min10 + min1 + ":" + sec10 + sec1);

        /* AI 추천
        int totalSec = (int)playSeconds;

        int TimeHour = (totalSec / 3600);
        int TimeMin = ((totalSec % 3600) / 60);
        int TimeSec = totalSec % 60;

        Debug.Log($"{TimeHour}:{TimeMin:D2}:{TimeSec:D2}");
        */



        // 골드 분배
        int goldPerMember = gold / members;
        int leaderBonus = gold % members;
        Debug.Log($"1인당 {goldPerMember}G, 리더 보너스 {leaderBonus}G");

        //경험치
        int baseExp = kills * expPerKill;
        int finalExp = (int)(baseExp * expRate);
        Debug.Log($"경험치 {finalExp} (기본 {baseExp})");

        //레벨
        int level = 1 + (finalExp / 100);
        int nextLevelExp = 100 - (finalExp % 100);
        Debug.Log($"Lv {level}, 다음 레벨까지 {nextLevelExp}");

        // 평균 데미지
        float avgDamage = (float)totalDamage / hits;
        Debug.Log($"평균 데미지 {avgDamage}");
    }


}
