using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public static bool GameIsPaused = false;    

    // Reference to the generated InputActions class
    private PlayerControls controls;

    void Awake()
    {
        // Initialize the input actions
        controls = new PlayerControls();
        controls.Gameplay.Pause.performed += ctx => TogglePause();
    }

    void OnEnable()
    {
        // Enable the input actions
        controls.Gameplay.Enable();
    }

    void OnDisable()
    {
        // Disable when object is inactive
        controls.Gameplay.Disable();
    }
    
    void Start()
    {
        // Safeguard: make sure game starts unpaused
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    private void TogglePause()
    {
        if (GameIsPaused) Resume();
        else Pause();
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void RestartLevel()
    {
        // Reset time scale so the game runs normally
        Time.timeScale = 1f;
        GameIsPaused = false;

        // Reload the currently active scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadMenu()
    {
        // Assuming you have a scene named "MainMenu"
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}