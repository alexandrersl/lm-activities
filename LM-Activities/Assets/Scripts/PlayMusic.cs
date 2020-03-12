using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public new string name;
    public void PlaySound()
    {
        Debug.Log("roblox");
        FindObjectOfType<AudioManager>().Play(name);
    }
}
