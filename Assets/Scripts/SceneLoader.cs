using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string newScene;

    public data DataSet;

    void Start() {
        DataSet = GameObject.Find("DataSet").GetComponent<SOAcces>().DataSet;    
    }
    void OnMouseDown()
    {
        if(newScene == "") {
            
        }
        SceneManager.LoadScene(newScene, LoadSceneMode.Single);    
    }
}
