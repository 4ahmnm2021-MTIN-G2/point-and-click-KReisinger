using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string newScene;

    void OnMouseDown()
    {
        SceneManager.LoadScene(newScene, LoadSceneMode.Single);    
    }
}
