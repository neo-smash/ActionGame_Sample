using UnityEngine;
using System.Collections.Generic;

public class CharacterMoverPresenter : MonoBehaviour
{
    [SerializeField] private CharacterParameterManager _parameterManager;
    [SerializeField] private GroundCharacterMover _groundMover;
    [SerializeField] private SwimmingCharacterMover _swimmingMover;

    private void Awake()
    {
        _groundMover.SetParameters(_parameterManager);
        _swimmingMover.SetParameters(_parameterManager);
    }
}
