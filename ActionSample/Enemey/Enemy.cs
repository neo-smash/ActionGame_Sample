using UnityEngine;

/// <summary>
/// 仮の敵のクラス
/// </summary>
public class Enemy : MonoBehaviour, IPlayerContactable
{
    [SerializeField] private float contactDamage = 10f;

    /// <summary>
    /// プレイヤーと接触した時の処理
    /// </summary>
    public void OnPlayerContact(GameObject player)
    {
        // プレイヤーのHP管理スクリプトを取得
        if (player.TryGetComponent(out CharacterParameterManager parameterManager))
        {
            parameterManager.CurrentHP.Value -= contactDamage;
        }
    }
}
