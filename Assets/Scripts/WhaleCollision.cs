using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleCollision : MonoBehaviour
{
   void OnTriggerEnter(Collider other){
        if (other.CompareTag("MainCamera")){
            Debug.Log("WhaleHit");
        }
    }
}
