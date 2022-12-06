using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyHandler : MonoBehaviour
{

    public int keysCollected;
    public TextMeshProUGUI keysText;

    // Start is called before the first frame update
    void Start()
    {
        keysCollected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (keysCollected < 5){
            keysText.text = "Keys: " + keysCollected.ToString() + " / 5";
        }
        else{
            keysText.text = "Unlock the treasure chest";
        }
    }
}
