using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Score score;

    public void addPoints(int points)
    {
        score.add(points);
    }
}
