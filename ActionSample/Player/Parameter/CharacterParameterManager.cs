using UnityEngine;
using UniRx;

public class CharacterParameterManager : MonoBehaviour
{
    [SerializeField] private CharacterParametersSO _parameterSO;

    public ReactiveProperty<float> CurrentHP { get; private set; }
    public ReactiveProperty<float> MoveSpeed { get; private set; }
    public ReactiveProperty<float> JumpPower { get; private set; }

    private void Awake()
    {
        // SOから初期値で初期化（プレイ中はこのインスタンスで操作）
        CurrentHP = new ReactiveProperty<float>(_parameterSO.MaxHP);
        MoveSpeed = new ReactiveProperty<float>(_parameterSO.MoveSpeed);
        JumpPower = new ReactiveProperty<float>(_parameterSO.JumpPower);
    }
}
