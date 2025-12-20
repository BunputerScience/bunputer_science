/*
 * Author: Ichiro Miyasato
 * File: MainMenu.cs
 * Description: Handles the main menu functionality such as playing the game and quitting the game.
 */
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Load the game scene when the player clicks the "Play" button
    public void PlayGame()
    {
        SceneManager.LoadScene("LogicGateChamber");
    }

    // Log a message and quit the game when the player clicks the "Quit" button
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
