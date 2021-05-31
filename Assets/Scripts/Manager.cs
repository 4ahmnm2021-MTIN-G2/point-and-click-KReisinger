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
            CheckStatus();
        }
    }
    public bool _docSchrank = false;
    public bool docSchrank{
        get
        {
            return _docSchrank;
        } 
        set
        {
          
            _docSchrank = value; 
            if(_tree == true) {
            } 
            CheckStatus();
        }
    }
    public bool _tree = false;
    public bool tree{
        get
        {
            return _tree;
        } 
        set
        {
            _tree = value; 
            CheckStatus();
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
            CheckStatus();
        }
    }

    public bool _key_Haustuere = false;
    public bool key_Haustuere{
        get
        {
            return _key_Haustuere;
        } 
        set
        {
            _key_Haustuere = value; 
            DataSet.key_Haustuere  = value;
            CheckStatus();
        }
    }
    
    void CheckStatus() {
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
