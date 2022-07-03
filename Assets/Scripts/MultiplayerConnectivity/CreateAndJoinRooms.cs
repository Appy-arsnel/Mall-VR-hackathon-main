using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public InputField createInput;
    public InputField joinInput;

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createInput.text);

    }

    public void JoinRoom()
    {
           PhotonNetwork.JoinRoom(joinInput.text);
        if(PhotonNetwork.CurrentRoom ==null){
            Debug.Log("Error");
        }
    }
    
    
    public override void OnJoinedRoom()
    {
       // EnterVR();
       
        PhotonNetwork.LoadLevel("main");
    }
}
