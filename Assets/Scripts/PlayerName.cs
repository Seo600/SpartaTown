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

    public void SaveName()
    {
        CharacterManager.name = inputFieldName.text;
        inputFieldName.text = "";
    }
}
