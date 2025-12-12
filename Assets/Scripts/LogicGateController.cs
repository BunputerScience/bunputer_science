using UnityEngine;

public enum GateType { NOT, AND, OR, XOR, NAND, NOR, ONLYIF }

public class LogicGateController : MonoBehaviour
{
    public GateType gateType;
    public bool inputA;
    public bool inputB;

    public bool EvaluateGate()
    {
        switch (gateType)
        {
            case GateType.NOT:
                return !inputA; // ignores B
            case GateType.AND:
                return inputA && inputB;
            case GateType.OR:
                return inputA || inputB;
            case GateType.XOR:
                return inputA ^ inputB;
            case GateType.NAND:
                return !(inputA && inputB);
            case GateType.NOR:
                return !(inputA || inputB);
            case GateType.ONLYIF:
                return (!inputA) || inputB;
            default:
                return false;
        }
    }
}
