using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestCollection : MonoBehaviour
{
    public Rigidbody m_Rigidbody;
    public KeyHandler keyHandler;
    public Renderer openChest;
    public Renderer openGold;
    public bool WhaleBool = false;

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            if(keyHandler.keysCollected == 5){
                m_Rigidbody.constraints = RigidbodyConstraints.FreezePosition;
                openChest.enabled = true;
                openGold.enabled = true;
                WhaleBool = true;
                gameObject.SetActive(false);
            }
        }
    }
}

