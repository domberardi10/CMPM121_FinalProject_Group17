using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleComingtoScreen : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            gameObject.SetActive(false);
            
        }
    }
}

