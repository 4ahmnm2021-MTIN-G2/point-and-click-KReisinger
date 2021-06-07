using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public data DataSet;

    void Start() {
        DataSet.basket = false;
        DataSet.tub = false;
        DataSet.sofa = false;
        DataSet.tv = false;
        DataSet.peppa = false;
        DataSet.cabinets = false;
        DataSet.fridge = false;
        DataSet.tree = false;
        DataSet.key_Arbeitszimmer = false;
        DataSet.key_Haustuere = false;
    }


    public void StatGame() {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }

    public void StopGame() {
        Application.Quit();
    }
}
