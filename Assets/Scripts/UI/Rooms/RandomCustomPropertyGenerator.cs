using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class RandomCustomPropertyGenerator : MonoBehaviour
{
    [SerializeField]
    private TMP_Text m_Text;


    private ExitGames.Client.Photon.Hashtable _myCustomProperties =  new ExitGames.Client.Photon.Hashtable();
    

    void SetCustomNumber()
    {
        System.Random random = new System.Random();
        int result = random.Next(0,99);
        m_Text.text =  result.ToString();
        _myCustomProperties["RandomNumber"] = result;
       // PhotonNetwork.LocalPlayer.CustomProperties = _myCustomProperties;
       PhotonNetwork.SetPlayerCustomProperties(_myCustomProperties);
    }

    public void OnCLick_Button()
    {
        SetCustomNumber();
    }
}
