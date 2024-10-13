using UnityEngine;

public class CharacterSetActive : MonoBehaviour
{
    [SerializeField] private GameObject penguin;
    [SerializeField] private GameObject knight;

    public void Awake()
    {
        if(CharacterManager.characterNumber == 1)
        {
            penguin.SetActive(true);
            knight.SetActive(false);
        }
        else
        {
            penguin.SetActive(false);
            knight.SetActive(true);
        }
    }
}