using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    [SerializeField] private InputField inputFieldName;

    private void Awake()
    {
        inputFieldName = GetComponent<InputField>();
    }

    public void StopTime()
    {
        Time.timeScale = 0;
    }

    public void SaveName()
    {
        CharacterManager.name = inputFieldName.text;
        inputFieldName.text = "";
        Time.timeScale = 1;
    }
}
