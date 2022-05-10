using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public GameObject key;
    public float startTime=0;
    public float currentTime;
    public float keyTime = 42f;
    // Start is called before the first frame update
    void Start()
    {
        startTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        startTime += Time.deltaTime;
        currentTime = keyTime - startTime;
        //time = 20 - time;
        if (currentTime <= 0)
        {
            currentTime = 0;
            key.gameObject.SetActive(false);
        }
        timerText.text = string.Format("Key expires in : {0:F2} ", (currentTime));
        
        
        
    }
}
