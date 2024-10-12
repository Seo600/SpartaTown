using UnityEngine;

public class InGameButton: MonoBehaviour
{
    public GameObject inGameChangeName;
    public GameObject penguin;
    public GameObject knight;

    public void NameChangeButton()
    {
        inGameChangeName.SetActive(true);
        penguin.SetActive(false);
        knight.SetActive(false);
    }

    public void NameSaveButton()
    {
        inGameChangeName.SetActive(false);
        if(CharacterManager.characterNumber == 1)
        {
            penguin.SetActive(true);
        }
        else
        {
            knight.SetActive(true);
        }
    }
}
