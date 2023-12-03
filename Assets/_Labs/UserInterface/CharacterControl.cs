using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        float hdirection;
        float vdirection;
        hdirection = Input.GetAxis("Horizontal");
        vdirection = Input.GetAxis("Vertical");
        if(hdirection > 0) {
            anim.SetInteger("Direction", 1);

        }
        if(hdirection < 0) {
            anim.SetInteger("Direction", 3);

        }
        if(vdirection > 0) {
            anim.SetInteger("Direction", 0);

        }

        if(vdirection < 0) {
            anim.SetInteger("Direction", 2);

        }
    }
}
