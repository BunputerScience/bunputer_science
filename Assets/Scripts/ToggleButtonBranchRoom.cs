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