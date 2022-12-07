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
         if(Input.GetKey(KeyCode.D)){
            anim.SetBool("isRight", true); 
            anim.SetBool("isLeft", false); 
            anim.SetBool("isIdle", false); 
        }
        else if(Input.GetKey(KeyCode.A)){
            anim.SetBool("isLeft", true );
             anim.SetBool("isRight", false);  
             anim.SetBool("isIdle", false);  
        }
       
        else{
             anim.SetBool("isLeft", false );
             anim.SetBool("isRight", false); 
             anim.SetBool("isIdle", true); 
        }
    }
}
