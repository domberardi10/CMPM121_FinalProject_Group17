using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySound : MonoBehaviour
{
    private AudioSource keySource;

    void Start()
    {
        keySource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Key")){
            keySource.Play();
        }
    }
}
