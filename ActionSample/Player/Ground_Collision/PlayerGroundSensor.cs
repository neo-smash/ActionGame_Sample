using UnityEngine;

/// <summary>
/// キャラクターの地面接触を検知する
/// </summary>
public class PlayerGroundSensor : MonoBehaviour
{
    public bool IsGrounded { get; private set; }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent(out IStepOnable stepOnable))
        {
            //踏んだオブジェクトがIStepOnableを実装している場合
            stepOnable.OnSteppedOn();
        }
        else if (other.gameObject.CompareTag("Ground"))
        {
            IsGrounded = true;
            Debug.Log("地面に接触した");
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            IsGrounded = false;
            Debug.Log("地面から離れた");
        }
    }
}
