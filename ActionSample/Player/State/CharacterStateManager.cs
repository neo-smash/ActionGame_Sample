using UnityEngine;
using UniRx;

/// <summary>
/// キャラクターの現在の状態を管理し、各種アクションの可否を判定する
/// </summary>
public class CharacterStateManager : MonoBehaviour
{
    [SerializeField] private PlayerGroundSensor groundSensor;

    //現在の状態
    public ReactiveProperty<CharacterState> CurrentState
    = new ReactiveProperty<CharacterState>(CharacterState.Idle);

    //現在の状態で移動可能かどうか
    public bool CanMove => CanMoveInCurrentState();

    //現在の状態でジャンプ可能かどうか
    public bool CanJump => CanJumpInCurrentState();

    private void Awake()
    {
        if (groundSensor == null)
            groundSensor = GetComponentInChildren<PlayerGroundSensor>();
    }

    private bool CanMoveInCurrentState()
    {
        var state = CurrentState.Value;
        return state == CharacterState.Idle ||
               state == CharacterState.Running ||
               state == CharacterState.Jumping;
    }

    private bool CanJumpInCurrentState()
    {
        var state = CurrentState.Value;
        return groundSensor != null && groundSensor.IsGrounded &&
               (state == CharacterState.Idle || state == CharacterState.Running);
    }

    public void SetState(CharacterState state)
    {
        CurrentState.Value = state;
    }
}
