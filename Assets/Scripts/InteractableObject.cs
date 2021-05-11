using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
      public UnityEvent clicked;

    
    void OnMouseDown()
    { 
           clicked.Invoke();    
        GameObject.Find("ObjectName").GetComponent<Text>().text = this.gameObject.name;
        // Debug.Log("click");
    }


    
}
