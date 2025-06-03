using UnityEngine;
using UniRx;

/// <summary>
/// キャラクターのアニメーションを管理する
/// </summary>
public class AnimationController : MonoBehaviour
{
    [SerializeField] private CharacterStateManager _characterStateManager;

    private void Start()
    {
        _characterStateManager.CurrentState
        .Subscribe(OnStateChanged)
        .AddTo(this);
    }

    private void OnStateChanged(CharacterState state)
    {
        switch (state)
        {
            case CharacterState.Idle:
                //アニメーションをIdleにする
                break;
            case CharacterState.Jumping:
                //アニメーションをJumpにする
                break;
            case CharacterState.Running:
                //アニメーションをRunにする
                break;
            case CharacterState.Swimming:
                //アニメーションをSwimにする
                break;
        }
    }
}