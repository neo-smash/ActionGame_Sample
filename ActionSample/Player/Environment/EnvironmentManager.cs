using UnityEngine;

/// <summary>
/// キャラクターのいる場所を管理する
/// </summary>
public class EnvironmentManager : MonoBehaviour
{
    private bool _isGroundArea;
    private bool _isInWaterArea;

    public bool IsGroundArea => _isGroundArea;
    public bool IsInWaterArea => _isInWaterArea;

    private void Awake()
    {
        // デバッグ用
        _isGroundArea = true;
        _isInWaterArea = false;
    }
}
