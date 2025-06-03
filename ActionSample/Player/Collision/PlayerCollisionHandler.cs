using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.TryGetComponent(out IPlayerContactable contactable))
        {
            contactable.OnPlayerContact(gameObject);
        }
        else if (other.gameObject.TryGetComponent(out IPlayerTriggerable triggerable))
        {
            triggerable.OnPlayerTrigger(gameObject);
        }
    }
}


