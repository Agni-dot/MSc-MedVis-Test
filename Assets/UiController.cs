using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiController : MonoBehaviour
{
    public void Quit () {
        Debug.Log("The application has quit");
        Application.Quit();
     }
     public void ChangeScene(string name) {
        SceneManager.LoadScene(name);
        
    }
}
