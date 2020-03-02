using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	public float timeStart = 5; 
    public Text textBox;
    // Start is called before the first frame update
    void Start()
    {
        textBox.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= 1 * Time.deltaTime;
        textBox.text = Mathf.Round(timeStart).ToString(); 

        if (timeStart <= 0){
        	textBox.color = Color.red;
        	timeStart =0;
        	textBox.text = timeStart.ToString();
        }
    }
}
