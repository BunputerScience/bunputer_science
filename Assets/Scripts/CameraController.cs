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