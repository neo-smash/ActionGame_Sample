using UnityEngine;
using UniRx;

/// <summary>
/// キャラクターの移動入力を購読して、移動を実行する
/// </summary>
public class CharacterMoveInputHandler : MonoBehaviour
{
    [SerializeField] private MoveInputEventManager _moveInputEventManager;
    [SerializeField] private EnvironmentManager _environmentManager;
    [SerializeField] private GroundCharacterMover _groundMover;
    [SerializeField] private SwimmingCharacterMover _swimmingMover;

    private void Start()
    {
        _moveInputEventManager.OnMove
            .Subscribe(dir =>
            {
                GetCurrentMover().Move(new Vector2(dir.x, 0f));
            })
            .AddTo(this);

        _moveInputEventManager.OnJump
            .Subscribe(_ => GetCurrentMover().Jump())
            .AddTo(this);
    }

    private ICharacterMover GetCurrentMover()
    {
        return _environmentManager.IsInWaterArea ?
        (ICharacterMover)_swimmingMover :
        (ICharacterMover)_groundMover;
    }
}
