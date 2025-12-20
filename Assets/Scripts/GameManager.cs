/*
 * Author: Ichiro Miyasato
 * File: GameManager.cs
 * Description: This class manages the game state and persists it across scenes.
 */

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

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
