using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestCollection : MonoBehaviour
{
    public KeyHandler keyHandler;
    public bool WhaleBool = false;

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            if(keyHandler.keysCollected == 5){
               
               //GameObject newChest = GameObject.FindGameObjectsWithTag("Open")[0];
               //newChest.SetActive(true);

               WhaleBool = true;
            
               gameObject.SetActive(false);
            }
        }
    }
}

