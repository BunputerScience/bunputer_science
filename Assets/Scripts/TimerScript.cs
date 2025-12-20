/*
 * Author: Ichiro Miyasato
 * File: TimerScript.cs
 * Description: This class manages the game timer.
 */

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public float timeRemaining = 120f; // total time in seconds
    public Text timerText;             // assign in Inspector
    private bool timerActive = false;
    private bool isGameOver = false;

    void Update()
    {
        if (timerActive && !isGameOver)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                UpdateTimerDisplay(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                GameOver();
            }
        }
    }

    public void StartTimer()
    {
        timerActive = true;
    }

    void UpdateTimerDisplay(float timeToDisplay)
    {
        int minutes = Mathf.FloorToInt(timeToDisplay / 60);
        int seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void GameOver()
    {
        isGameOver = true;
        Debug.Log("Game Over!");
        //SceneManager.LoadScene("GameOverScene");
    }
}
