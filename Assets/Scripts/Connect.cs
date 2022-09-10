using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Connect : MonoBehaviourPunCallbacks
{

    public TMP_InputField nickname;
    public TMP_Text Conect;
    // Start is called before the first frame update
   public void onclick()
    {
        PhotonNetwork.NickName = nickname.text;
        
        Conect.text = "Connecting...";     
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("Disconnect the server" + cause);
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to server");
        PhotonNetwork.JoinLobby();
    }
    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("Main menu");
    }
    

}

