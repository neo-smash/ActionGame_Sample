using UnityEngine;
using UnityEngine.InputSystem;
using System;
using UniRx;

/// <summary>
/// キャラクターの移動入力を管理する
/// </summary>
public class MoveInputEventManager : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;

    //外部から購読するためのプロパティ
    public IObservable<Vector2> OnMove => _onMove;
    public IObservable<Unit> OnJump => _onJump;

    //内部でイベントを管理するSubject
    private readonly Subject<Vector2> _onMove = new Subject<Vector2>();
    private readonly Subject<Unit> _onJump = new Subject<Unit>();

    private InputAction _moveAction;
    private InputAction _jumpAction;

    private void Awake()
    {
        _moveAction = _playerInput.actions["Move"];
        _jumpAction = _playerInput.actions["Jump"];
    }

    private void OnEnable()
    {
        _moveAction.performed += ctx => _onMove.OnNext(ctx.ReadValue<Vector2>());
        _moveAction.canceled += ctx => _onMove.OnNext(Vector2.zero);
        _jumpAction.performed += _ => _onJump.OnNext(Unit.Default);
    }

    private void OnDisable()
    {
        _moveAction.performed -= null;
        _moveAction.canceled -= null;
        _jumpAction.performed -= null;
    }
}
