using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LightswitchProbably : MonoBehaviour
{
    public event Action<bool> LightChange;
    public bool isLit;

    // Start is called before the first frame update
    void Start()
    {
        DoLightChange(isLit);    
    }

    void OnMouseDown() {
        isLit = !isLit;
        DoLightChange(isLit);

    }

    
    void DoLightChange(bool isLit) {
        if (LightChange != null) {
            LightChange(isLit);

        }


    
        
    }
}
