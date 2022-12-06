using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    private bool musicPlaying = false;
    private AudioSource musicSource;
    
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        musicSource = GetComponent<AudioSource>();
        if (!musicPlaying) {
            musicSource.Play();
            musicPlaying = true;
        }

    }
}
