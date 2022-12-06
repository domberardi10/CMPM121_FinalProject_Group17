using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissionControl : MonoBehaviour
{

    public float emissionTimer = 0f;
    private Material myMaterial;
    private Vector4 currentColor;

    // Start is called before the first frame update
    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
        currentColor = myMaterial.GetColor("_EmissionColor");
    }

    // Update is called once per frame
    void Update()
    {

        emissionTimer += Time.deltaTime;
        if (emissionTimer < 5f && emissionTimer > 4f){
            myMaterial.SetColor("_EmissionColor", currentColor * 0.999f);
            currentColor = currentColor * 0.998f;
        }
        if (emissionTimer > 5f && emissionTimer < 6f){
            myMaterial.SetColor("_EmissionColor", currentColor * 1.001f);
            currentColor = currentColor * 1.002f;
        }
        if (emissionTimer >= 10f){
            emissionTimer = 0f;
        }
    }
}
