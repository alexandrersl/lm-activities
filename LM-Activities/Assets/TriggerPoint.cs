using UnityEngine;

public class TriggerPoint : MonoBehaviour
{
    public GameManager gameManager;

    public void OnTriggerEnter(Collider collider)
    {
        gameManager.addPoints(1);
    }
}
