using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleCollision : MonoBehaviour
{
    public ChestCollection chestflag;

    public Renderer rend;

    public GameObject whale;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }
    void Update()
    {
        if (chestflag.WhaleBool)
        {
            if (!rend.enabled)
            {
                rend.enabled = true;
            }
            Vector3 whalePos = whale.transform.position;
            whalePos.z += 1f;
            whale.transform.position = whalePos;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            Debug.Log("WhaleHit");
        }
    }
}
