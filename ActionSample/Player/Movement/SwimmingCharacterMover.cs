using UnityEngine;

/// <summary>
/// 水の中でのキャラクターの移動を管理する
/// </summary>
public class SwimmingCharacterMover : MonoBehaviour, ICharacterMover
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

    }

    public void Jump()
    {

    }

    public void SetParameters(CharacterParameterManager parameters)
    {
        _parameters = parameters;
    }
}
