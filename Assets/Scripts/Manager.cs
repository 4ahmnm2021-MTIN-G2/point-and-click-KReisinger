using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public data DataSet; 
    public Text TaskBarTxt; 

    public GameObject Menu;


    // Untersuchen
    public bool _basket = false;
    public bool basket{
        get
        {
            return _basket;
        } 
        set
        {
            _basket = value; 
            DataSet.basket = value;
            Checkcon();
        }
    }
    public bool _con1 = false;
    public bool con1{
        get
        {
            return _con1;
        } 
        set
        {
            _con1 = value; 
            Checkcon();
        }
    }
    public bool _con2 = false;
    public bool con2{
        get
        {
            return _con2;
        } 
        set
        {
            _con2 = value; 
            Checkcon();
        }
    }

    // Keys

    public bool _key_Arbeitszimmer = false;
    public bool key_Arbeitszimmer{
        get
        {
            return _key_Arbeitszimmer;
        } 
        set
        {
            _key_Arbeitszimmer = value; 
            DataSet.key_Arbeitszimmer = value;
            Checkcon();
        }
    }

    void Checkcon() {
        // if(_con0 == true && _con1 == true && _con2 == true) {
            // Debug.Log("Player Won");
        // }
    }

    void Start() {
        DataSet = GameObject.Find("DataSet").GetComponent<SOAcces>().DataSet;
        DataSet.key_Arbeitszimmer = false;
        DataSet.key_Haustuere = false;
    }

    public void SetNotification(string notification) {
        TaskBarTxt.text = notification;
    }
}
