using UnityEngine;

public class CharacterSetActive : MonoBehaviour
{
    [SerializeField] private GameObject penguin;
    [SerializeField] private GameObject kNight;

    public void Awake()
    {
        if(CharacterManager.characterNumber == 1)
        {
            penguin.SetActive(true);
            kNight.SetActive(false);
        }
        else
        {
            penguin.SetActive(false);
            kNight.SetActive(true);
        }
    }
}