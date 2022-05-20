using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float MaxTime;
    public Image img;
    
    private float currentTime;
    void Start()
    {
        img = GetComponent<Image>();
        currentTime = 0;
    }


    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= MaxTime)
        {
            currentTime = 0;
        }

        img.fillAmount = currentTime / MaxTime;
    }
}
