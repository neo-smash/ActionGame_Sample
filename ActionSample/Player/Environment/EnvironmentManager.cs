using UnityEngine;

public class EnvironmentManager : MonoBehaviour
{
    private bool _isGround;
    private bool _isInWater;

    public bool IsGround => _isGround;
    public bool IsInWater => _isInWater;

    private void Awake()
    {
        _isGround = true;
        _isInWater = false;
    }

    public void SetEnvironment(bool isGround, bool isInWater)
    {
        _isGround = isGround;
        _isInWater = isInWater;
    }
}
