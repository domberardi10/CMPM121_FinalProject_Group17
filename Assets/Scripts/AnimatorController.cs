using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
     private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
         anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.D)){
            anim.SetBool("isRight", true); 
            anim.SetBool("isLeft", false); 
        }
        else if(Input.GetKeyDown(KeyCode.A)){
            anim.SetBool("isLeft", true );
             anim.SetBool("isRight", false);   
        }
        else if(Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.D)){
            anim.SetBool("isLeft", true );
             anim.SetBool("isRight", false);   
        }
    }
}
