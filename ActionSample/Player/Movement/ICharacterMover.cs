using UnityEngine;

public interface ICharacterMover
{
    void Move(Vector2 dir)
    {
        Debug.Log("移動");
    }
    void Jump()
    {
        Debug.Log("ジャンプ");
    }

    //パラメーターを設定する
    void SetParameters(CharacterParameterManager parameters);
}
