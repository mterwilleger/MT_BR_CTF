using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ChestBehavior : MonoBehaviourPun
{
    void Start()
    {
        //Set the tag of this GameObject to Player
        gameObject.tag = "Chest";
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            photonView.RPC("DestroyChest", RpcTarget.AllBuffered); 
        } 
    }

    [PunRPC]
    public void DestroyChest()
    {
        Destroy(gameObject);
    }
}
