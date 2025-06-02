using UnityEngine;

[CreateAssetMenu(fileName = "CharacterParameter", menuName = "ScriptableObjects/CharacterParameter", order = 1)]
public class CharacterParametersSO : ScriptableObject
{
    [Header("基本パラメーター")]
    public float MaxHP = 100f;
    public float MoveSpeed = 5f;
    public float JumpPower = 10f;
    public float AttackPower = 20f;
}
