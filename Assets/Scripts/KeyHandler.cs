using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class KeyHandler : MonoBehaviour
{

    public int keysCollected;
    private Label keysText;
    public UIDocument uiDoc;
    private VisualElement frame;

    // Start is called before the first frame update
    void Start()
    {
        keysCollected = 0;
        var rootVisualElement = uiDoc.rootVisualElement;
        frame = rootVisualElement.Q<VisualElement>("Frame");
        keysText = frame.Q<Label>("Keys");
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
