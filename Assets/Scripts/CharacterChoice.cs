using UnityEngine;

public class CharacterChoice : MonoBehaviour
{
    public void FirstCharacter()
    {
        CharacterManager.characterNumber = 1;
    }

    public void SecondCharacter()
    {
        CharacterManager.characterNumber = 2;
    }
}