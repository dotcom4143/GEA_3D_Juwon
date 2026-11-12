using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    public int height = 3;

    [ContextMenu("계단")]
    public void Stair()
    {

        string hierarchy = "";

        for (int row = 1; row <= height; row++)
        {
            for (int col = 0; col < row; col++)
            {
                hierarchy += "*";
            }
            hierarchy += "\n";
        }
        Debug.Log(hierarchy);
    }

    [ContextMenu("역계단")]
    public void AntiStair()
    {

        string hierarchy = "";

        for (int row = height; row >= -1; row--)
        {
            for (int col = 0; col < row; col++)
            {
                hierarchy += "*";
            }
            hierarchy += "\n";
        }
        Debug.Log(hierarchy);
    }

    [ContextMenu("반대계단")]
    public void RevStair()
    {

        string hierarchy = "";

        for (int row = 1; row <= height; row++)
        {
            int spaceCount = height - row;
            int starCount = row;
            for (int i = 0; i < spaceCount; i++)
            {
                hierarchy += " ";
            }
            for (int i = 0; i < starCount; i++)
            {
                hierarchy += "*";
            }
            hierarchy += "\n";
        }
        Debug.Log(hierarchy);

    }

    [ContextMenu("트리")]
    public void Hitree()
    {
        string result = "";

        for (int row = 1; row <= height; row++)
        {
            int spaceCount = height - row;
            int starCount = 2 * row - 1;

            for (int i = 0; i < spaceCount; i++)
            {
                result += " ";
            }

            for (int i = 0; i < starCount; i++)
            {
                result += "*";
            }

            result += "\n";

        }
        Debug.Log(result);
    }

}
    