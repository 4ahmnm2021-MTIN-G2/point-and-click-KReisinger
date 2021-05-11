using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public data DataSet; 
    public bool _con0 = false;
    public bool con0{
        get
        {
            return _con0;
        } 
        set
        {
            _con0 = value; 
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

    void Checkcon() {
        if(_con0 == true && _con1 == true && _con2 == true) {
            Debug.Log("Player Won");
        }
    }

    void Start() {
        Debug.Log(DataSet._basket);
    }
}
