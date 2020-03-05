using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBall : MonoBehaviour
{
    
    public RandomSpawner rdS;

    public void OnTriggerEnter(Collider collider)
    {
        rdS.SpawnRandom();
    }
}