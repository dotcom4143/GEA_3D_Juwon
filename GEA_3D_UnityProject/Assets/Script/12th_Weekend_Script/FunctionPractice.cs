using UnityEngine;

public class FunctionPractice : MonoBehaviour
{
    string ScoreGrade(int score)
    {
        if (score >= 90) return "A급"; // A급이 아니면 B급 검사로 내려감
        if (score >= 70) return "B급"; // B급이 아니면 원숭이로 강등
        if (score >= 50) return "원숭이"; // 우끼끼도 아니면 핵분열이 필요한 쓰래기로 분류
        return "사람 아니야"; // !@#*@#!$&@*!$&@#!(*@#!@$&!)!!@#(! (49점 미만이면 사람 아니라는 뜻)
    }

    [ContextMenu("함수 실습")]
    void ShowGrades()
    {
        Debug.Log("95 점 : " + ScoreGrade(95));
        Debug.Log("70 점 : " + ScoreGrade(70));
        Debug.Log("50 점 : " + ScoreGrade(50));
        Debug.Log("10 점 : " + ScoreGrade(10));
    }
}
