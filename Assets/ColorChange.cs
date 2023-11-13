using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    Renderer myRen;
    Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        myRen = GetComponent<Renderer>();
        myAnimator = GetComponent<Animator>();
        
    }

    public void ChangeColor() {
        myRen.material.color = Color.red;
        
    }
    void OnMouseDown() {
        myAnimator.SetTrigger("New Trigger");
    }

}
