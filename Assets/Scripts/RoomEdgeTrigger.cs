using UnityEngine;

public class RoomEdgeTrigger : MonoBehaviour {
    public CameraController cameraController;
    public Vector2 newRoomCenter;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            cameraController.MoveToRoom(newRoomCenter);
        }
    }
}