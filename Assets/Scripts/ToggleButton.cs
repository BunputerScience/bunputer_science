using UnityEngine;

public class ToggleButton : MonoBehaviour
{
    public bool isOn = false;
    public Color onColor = Color.green;
    public Color offColor = Color.red;

    public LogicGateTile connectedGate;
    public bool affectsInputA = true;

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
                if (affectsInputA) connectedGate.inputA = isOn;
                else connectedGate.inputB = isOn;
                connectedGate.EvaluateGate();
            }
        }
    }

    void UpdateColor()
    {
        if (sr != null)
            sr.color = isOn ? onColor : offColor;
    }
}