using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine;

public class PlayerListing : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private TMP_Text _text;

    public bool Ready = false;
    public Player Player { get; private set; }
    public void SetPlayerInfo(Player player)
    {
        Player = player;

        SetPlayerText(player);
    }

    public override void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps)
    {
        base.OnPlayerPropertiesUpdate(targetPlayer, changedProps);
        if (targetPlayer != null && targetPlayer ==  Player)
        {
            if (changedProps.ContainsKey("RandomNumber"))
            {
                SetPlayerText(targetPlayer);
            }
            
        }
    }

    private  void SetPlayerText(Player player)
    {
        int result = -1;

        if (player.CustomProperties.ContainsKey("RandomNumber"))
        {
            result = (int)player.CustomProperties["RandomNumber"];
        }

        _text.text = result.ToString() + " __" + player.NickName;
    }
}
