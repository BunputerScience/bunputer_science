using UnityEngine;

public class ButtonConfirm : MonoBehaviour
{
    public bool isOn = false;
    public Color onColor;
    public Color offColor;
    public GameObject wallToDestroy;
    public LogicGateController connectedGate;
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
            
            isOn = !isOn;
            UpdateColor();
            if (connectedGate != null)
            {
                bool result = connectedGate.EvaluateGate();

                if (result && wallToDestroy != null)
                {
                    Destroy(wallToDestroy);
                    Debug.Log("Puzzle solved!");
                }
                else
                {
                    Debug.Log("Puzzle failed.");
                }
            }
            else
            {
                Debug.LogWarning($"{name} has no connectedGate assigned!");
            }
        }
    }

        void UpdateColor()
    {
        if (sr != null)
            sr.color = isOn ? onColor : offColor;
    }
}