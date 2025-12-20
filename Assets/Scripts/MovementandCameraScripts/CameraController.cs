/*
 * Author: Ichiro Miyasato
 * File: CameraController.cs
 * Description: This script controls the movement of the camera in a 2D game.
 * The camera can be moved to a new room by calling the MoveToRoom method with the center of the new room.
 * The camera will move smoothly towards the target position at a constant speed.
 * The camera will stop moving once it reaches the target position.
 */
using UnityEngine;

public class CameraController : MonoBehaviour {
    public float moveSpeed = 10f;
    private Vector3 targetPosition;
    private bool isMoving = false;

    void Update() {
        if (isMoving) {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            if (transform.position == targetPosition) {
                isMoving = false;
            }
        }
    }

    public void MoveToRoom(Vector2 newRoomCenter) {
        targetPosition = new Vector3(newRoomCenter.x, newRoomCenter.y, transform.position.z);
        isMoving = true;
    }
}