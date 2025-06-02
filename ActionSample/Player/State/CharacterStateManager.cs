using UnityEngine;
using UniRx;

public class CharacterStateManager : MonoBehaviour
{
    public ReactiveProperty<CharacterState> CurrentState = new ReactiveProperty<CharacterState>(CharacterState.Idle);

    public bool CanMove => CurrentState.Value == CharacterState.Idle || CurrentState.Value == CharacterState.Running;
    public bool CanJump => CurrentState.Value == CharacterState.Idle || CurrentState.Value == CharacterState.Running;

    public void SetState(CharacterState state)
    {
        CurrentState.Value = state;
    }
}
