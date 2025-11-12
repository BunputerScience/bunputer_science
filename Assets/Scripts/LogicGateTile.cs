using UnityEngine;

public class LogicGateTile : MonoBehaviour
{
    public bool inputA = false;
    public bool inputB = false;

    public Color onColor = Color.green;
    public Color offColor = Color.red;

    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        UpdateColor(EvaluateGate());
    }

    public bool EvaluateGate()
    {
        bool result = inputA && inputB;
        UpdateColor(result);

        return result;
    }

    private void UpdateColor(bool result)
    {
        if (sr != null)
            sr.color = result ? onColor : offColor;
    }
}
