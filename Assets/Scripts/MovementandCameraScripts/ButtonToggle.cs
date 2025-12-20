/*
 * Author: Ichiro Miyasato
 * File: ButtonToggle.cs
 * Description: Handles the button toggle functionality for the A and B circle
 * buttons in each room.
 */
using UnityEngine;

public class ButtonToggle : MonoBehaviour
{
    public bool isOn = false;
    public Color onColor;
    public Color offColor;
    public LogicGateController connectedGate;
    public bool affectsInputA = true; // true = A, false = B
    
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
        }
        if (connectedGate != null)
            {
                if (affectsInputA) connectedGate.inputA = isOn;
                else connectedGate.inputB = isOn;
            }
            else
            {
                Debug.LogWarning($"{name} has no connectedGate assigned!");
            }
    }

    void UpdateColor()
    {
        if (sr != null)
            {
                sr.color = isOn ? onColor : offColor;
            }
    }
}