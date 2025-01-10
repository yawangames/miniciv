using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameDefinition GameDefinition;


    private void Awake()
    {
        Instance = this;
    }
}
