using System;
using UnityEngine;
using UnityEngine.UI;

public class TimeUI : MonoBehaviour
{
    [SerializeField] private Text timeText;

    
    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;
        timeText.text = time.ToString("HH:mm");
    }
}
