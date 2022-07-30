using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.Events;

public class PhotonCallbacks : MonoBehaviourPunCallbacks
{
    public static UnityEvent<Player> OnPlayerEntered = new UnityEvent<Player>();
    public static UnityEvent<Player> OnMeJoinedRoom = new UnityEvent<Player>();
    private void Start()
    {
      
        PhotonNetwork.ConnectUsingSettings();
        
    }
    public override void OnConnected()
    {
        base.OnConnected();
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        Debug.Log("Connected to Master");
        RoomOptions roomOptions = new RoomOptions { IsOpen = true, IsVisible = true, MaxPlayers = 20, PublishUserId = true };
        PhotonNetwork.JoinOrCreateRoom("DefaultRoom",roomOptions,TypedLobby.Default);
    }

    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();
        Debug.Log("Connected to Lobby");
        
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        Debug.Log("Connected to Room -" + PhotonNetwork.CurrentRoom.Name);
        Debug.Log("my User id - " + PhotonNetwork.LocalPlayer.UserId);
        OnMeJoinedRoom.Invoke(PhotonNetwork.LocalPlayer);

    }

    public override void OnLeftLobby()
    {
        base.OnLeftLobby();
        Debug.Log("On Lobby left");
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        base.OnDisconnected(cause);
        Debug.Log("Disconnected from photon");
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        base.OnPlayerEnteredRoom(newPlayer);
        Debug.Log("new Player Entered - " + newPlayer.UserId);
        OnPlayerEntered.Invoke(newPlayer);
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        base.OnPlayerLeftRoom(otherPlayer);
        Debug.Log("Player Left - " + otherPlayer.UserId);

    }

}
