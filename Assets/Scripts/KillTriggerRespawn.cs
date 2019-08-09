using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTriggerRespawn : MonoBehaviour
{
    public Transform respawnPos;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            other.gameObject.SetActive(false);
            other.gameObject.transform.position = respawnPos.position;
            other.gameObject.SetActive(true);
        }
    }
}
