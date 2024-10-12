using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [SerializeField] private Text timeText;
    private float time;

    
    // Update is called once per frame
    void Update()
    {
        time += UnityEngine.Time.deltaTime;
        timeText.text = time.ToString();
    }
}
