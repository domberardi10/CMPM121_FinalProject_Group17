using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollection : MonoBehaviour
{
    public KeyHandler keyHandler;

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            keyHandler.keysCollected += 1;
            gameObject.SetActive(false);
        }
    }
}
