/*
 * Author: Ichiro Miyasato
 * File: RoomEdgeTrigger.cs
 * Description: This class handles the room edge trigger logic in the game.
 * It moves the camera to a new room when the player collides with it.
 */

using UnityEngine;

public class RoomEdgeTrigger : MonoBehaviour {
    public CameraController cameraController;
    public Vector2 newRoomCenter;
    public bool isFirstRoom = false;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            // First room → always scroll
            if (isFirstRoom)
            {
                cameraController.MoveToRoom(newRoomCenter);
            }
            // Later rooms → scroll only if button pressed
            else if (GameManager.Instance.firstRoomButtonPressed)
            {
                cameraController.MoveToRoom(newRoomCenter);
            }
        }
    }
}