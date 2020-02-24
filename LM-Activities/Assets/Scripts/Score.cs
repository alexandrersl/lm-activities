using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "0";
    }

    public void add(int points)
    {
        scoreText.text = (int.Parse(scoreText.text)+points).ToString();
    }

}
