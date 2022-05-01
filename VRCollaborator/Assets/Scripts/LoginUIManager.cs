using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using Photon.Realtime;

public class LoginUIManager : MonoBehaviourPunCallbacks
{
    public GameObject ConnectOptionsPanelGameobject;
    public GameObject ConnectWithNamePanelGameobject;
    // Start is called before the first frame update
    private void Start()
    {
        ConnectOptionsPanelGameobject.SetActive(true);
        ConnectWithNamePanelGameobject.SetActive(false);
    }
}