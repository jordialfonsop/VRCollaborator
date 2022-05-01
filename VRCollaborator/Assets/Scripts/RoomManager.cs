/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using Photon.Realtime;

public class RoomManager : MonoBehaviourPunCallbacks{
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    public void JoinRandomRoom()
    {
       PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinRadandomField(short returnCode, string message)
    {
        Debug.Log(message);
        CreateAndJoinRoom();
    }

    private void CreateAndJoinRoom(){
        string randomRoomName="Room_"+Random.Range(0,100000);
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 20;
        PhotonNetwork.CreateRoom(randomRoomName, roomOptions);
    }
    public override void OnCreateRoom()
    {
        Debug.Log("A room is created with the name: "+PhotonNetwork.CurrentRoom.Name);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("The Local player: "+PhotonNetwork.NickName+" joined to "+PhotonNetwork.CurrentRoom.Name+" Player Count: "+PhotonNetwork.CurrentRoom.PlayerCount);
    }

    public override void OnPlayerEnterRoom(Photon.Realtime.Player newPlayer)
    {
        Debug.Log(newPlayer.NickName+"joined to "+PhotonNetwork.CurrentRoom.Name+" Player count: "+PhotonNetwork.CurrentRoom.PlayerCount);
    }
}*/
