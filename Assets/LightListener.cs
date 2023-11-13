using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LightListener : MonoBehaviour
{
    LightswitchProbably lightswitchProbably;
    Light myLight;

    void Awake() {
        lightswitchProbably = FindObjectOfType<LightswitchProbably>();
        
        if (!lightswitchProbably)
            Debug.LogWarning("Light Switch delegate missing!");
        }
    
    void OnEnable() {
        lightswitchProbably.LightChange += MyLightChange;
    }

    void OnDisable() {
        lightswitchProbably.LightChange -= MyLightChange;
    }

    void Start()
    {
        myLight = GetComponent<Light>();
        
    }
    void MyLightChange(bool isLit) {
        myLight.enabled = isLit;
    }

}



