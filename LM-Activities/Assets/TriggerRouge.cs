using UnityEngine;

public class TriggerRouge : MonoBehaviour
{
    public GameManager gameManager;

    public void OnTriggerEnter(Collider collider)
    {
        gameManager.addPoints(3);
    }
}

