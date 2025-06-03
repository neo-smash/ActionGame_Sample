using UnityEngine;
using UniRx;

/// <summary>
/// キャラクターのパラメータを管理する
/// </summary>
public class CharacterParameterManager : MonoBehaviour
{
    [SerializeField] private CharacterParametersSO _parameterSO;

    public ReactiveProperty<float> CurrentHP { get; private set; }
    public ReactiveProperty<float> MoveSpeed { get; private set; }
    public ReactiveProperty<float> JumpPower { get; private set; }

    private void Awake()
    {
        CurrentHP = new ReactiveProperty<float>(_parameterSO.MaxHP);
        MoveSpeed = new ReactiveProperty<float>(_parameterSO.MoveSpeed);
        JumpPower = new ReactiveProperty<float>(_parameterSO.JumpPower);
    }
}
