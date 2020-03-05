using UnityEngine;

public class TriggerJaune : MonoBehaviour
{
    public GameManager gameManager;

    public void OnTriggerEnter(Collider collider)
    {
        gameManager.addPoints(1);
    }
}