using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private static CharacterManager instance;

    public static string name ;
    public static int characterNumber = 1;

    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }


}
