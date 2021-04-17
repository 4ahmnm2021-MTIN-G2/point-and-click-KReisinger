using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnMouseDown()
    { 
        this.gameObject.active = false;
        GameObject.Find("ObjectName").GetComponent<Text>().text = this.gameObject.name;
        Debug.Log("click");
    }


    
}
