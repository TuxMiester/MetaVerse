using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.Events;
using Photon.Realtime;
using System;

public class PhotonManager : MonoBehaviourPun
{

    private void OnEnable()
    {
        PhotonCallbacks.OnPlayerEntered.AddListener(OnPlayerEntered);
    }

    private void OnDisable()
    {
        PhotonCallbacks.OnPlayerEntered.RemoveListener(OnPlayerEntered);

    }

    private void OnPlayerEntered(Player player)
    {
        
    }
}
