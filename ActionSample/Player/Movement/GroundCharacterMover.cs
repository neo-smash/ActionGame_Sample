using UnityEngine;

/// <summary>
/// 地面でのキャラクターの移動を管理する
/// </summary>
public class GroundCharacterMover : MonoBehaviour, ICharacterMover
{
    [SerializeField] private CharacterStateManager _characterStateManager;

    private CharacterParameterManager _parameters;
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 dir)
    {
        if (!_characterStateManager.CanMove) return;

        _characterStateManager.SetState(CharacterState.Running);
        var currentVelocity = _rigidbody2D.linearVelocity;
        _rigidbody2D.linearVelocity = new Vector2(dir.x * _parameters.MoveSpeed.Value, currentVelocity.y);
    }

    public void Jump()
    {
        if (!_characterStateManager.CanJump) return;

        _characterStateManager.SetState(CharacterState.Jumping);
        _rigidbody2D.AddForce(Vector2.up * _parameters.JumpPower.Value, ForceMode2D.Impulse);
    }

    public void SetParameters(CharacterParameterManager parameters)
    {
        _parameters = parameters;
    }
}
