using UnityEngine;

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
        Debug.Log("移動");
        _characterStateManager.SetState(CharacterState.Running);
    }

    public void Jump()
    {
        Debug.Log("ジャンプ");
        _characterStateManager.SetState(CharacterState.Jumping);
    }

    public void SetParameters(CharacterParameterManager parameters)
    {
        _parameters = parameters;
    }
}
