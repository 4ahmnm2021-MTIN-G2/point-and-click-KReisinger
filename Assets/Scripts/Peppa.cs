using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peppa : MonoBehaviour
{
    // Start is called before the first frame update
    public data DataSet;
    public Manager manager;

    public List<string> PeppaTexts;

    private int counter = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if(DataSet.peppa == false) {
            DataSet.peppa = true;
        }
        manager.SetNotification(PeppaTexts[counter]);
        if(counter != 2)  {
            counter ++;

        }
    }
}
