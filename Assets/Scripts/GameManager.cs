using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    // Example flags
    public bool firstRoomButtonPressed = false;
    public bool queuePuzzleSolved = false;
    public bool logicGateCleared = false;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // persists across scenes
        }
        else
        {
            Destroy(gameObject); // prevents duplicates
        }
    }
}
