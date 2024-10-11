using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void LoadCharacterScene()
    {
        SceneManager.LoadScene("CharacterChoiceScene");
    }

    public void LoadInputNameScene()
    {
        SceneManager.LoadScene("InputNameScene");
    }
}
