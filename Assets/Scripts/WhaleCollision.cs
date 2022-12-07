using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleCollision : MonoBehaviour
{
    public ChestCollection chestflag;

    public Renderer rend;

    public GameObject whale;

    public GameSceneManager sceneMgr;

    private AudioSource whaleNoise;

    void Start()
    {
        whaleNoise = GetComponent<AudioSource>();
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }
    void FixedUpdate()
    {
        if (chestflag.WhaleBool)
        {
            if (!rend.enabled)
            {
                whaleNoise.Play();
                rend.enabled = true;
            }
            Vector3 whalePos = whale.transform.position;
            whalePos.z -= 2f;
            whale.transform.position = whalePos;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            sceneMgr.LoadEndScene();
        }
    }
}
