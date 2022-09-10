using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Createandjoin : MonoBehaviourPunCallbacks
{

    public TMP_InputField Createinput;
    public TMP_InputField joininput;
    public  void CreateRoom()
    {
        PhotonNetwork.CreateRoom(Createinput.text);
    }
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joininput.text);
    }
    public override void OnJoinedRoom()
    {
        SceneManager.LoadScene("Game1");
        
    }
}
