/*
 * Author: Ichiro Miyasato
 * File: ToggleButtonBranchRoom.cs
 * Description: This class handles the toggle button functionality in the branch room.
 * The branch room is the second room from the starting room. Pressing the button at the
 * center of the room will open the left and right walls of the room, allowing the player to proceed
 * by their preference of difficulty of puzzles.
 */

using UnityEngine;

public class ToggleButtonBranchRoom : MonoBehaviour
{
    public bool isOn = false;
    public Color onColor = Color.green;
    public Color offColor = Color.red;
    public GameObject LeftWallBranch;
    public GameObject RightWallBranch;
    

    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        UpdateColor();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if(!isOn)
            {
                isOn = !isOn;
            }
            UpdateColor();

            GameManager.Instance.firstRoomButtonPressed = true;
            if (LeftWallBranch != null)
            {
                Destroy(LeftWallBranch);
            }

            if (RightWallBranch != null)
            {
                Destroy(RightWallBranch);
            }
        }
    }

        void UpdateColor()
    {
        if (sr != null)
            sr.color = isOn ? onColor : offColor;
    }
}