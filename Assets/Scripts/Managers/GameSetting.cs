using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Manager/GameSetting")]
public class GameSetting : ScriptableObject
{
    [SerializeField]
    private string _gameVersion = "0.0.1";
    public string GameVersion { get { return _gameVersion; } }
    [SerializeField]
    private string _nickName = "punfish";

    public string NickName
    {
        get {
            int value = Random.Range(0, 9999);
            return _nickName + value.ToString();
        }
    }
}
