using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using Photon.Realtime;
using TMPro;

public class HostGame : MonoBehaviourPunCallbacks
{
    public TMP_InputField PlayerName_InputName;
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    public void ConnectToPhotonServer(){
        if(PlayerName_InputName != null){
            PhotonNetwork.NickName = PlayerName_InputName.text;
            PhotonNetwork.ConnectUsingSettings();
            OnConnectedToMaster();
        }
    }
    // Update is called once per frame
    public override void OnConnected()
    {
       Debug.Log("Server is on!");
    }
    
    public void ConnectAnonymously(){
        PhotonNetwork.ConnectUsingSettings();
        OnConnectedToMaster();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.LoadLevel("World_School"); //create and join  rooms
    }

}