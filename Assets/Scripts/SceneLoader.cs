using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string newScene;

    public data DataSet;

    public Manager Manager;

    void Start() {
        DataSet = GameObject.Find("DataSet").GetComponent<SOAcces>().DataSet;   
        Manager = GameObject.Find("Manager").GetComponent<Manager>();  
    }
    void OnMouseDown()
    {
        if(newScene == "Arbeitszimmer" && DataSet.key_Arbeitszimmer == false) {
            Manager.SetNotification("Du musst zuerst den Schlüssel für das Arbeitszimmer finden!");
        } else if(newScene == "Draussen" && DataSet.key_Haustuere == false) {
            Manager.SetNotification("Du muss zuerst den Schlüssel für die Haustüre finden!");
        } else {
            SceneManager.LoadScene(newScene, LoadSceneMode.Single);    
        }
    }
}
