using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    public UnityEvent clicked;

    public UnityEvent looked;

    public UnityEvent picked;
    public GameObject Menu;

    
    void Start() {
      Menu = GameObject.Find("Menu").gameObject;
    }
    void OnMouseDown()
    { 
      GameObject.Find("ObjectName").GetComponent<Text>().text = this.gameObject.name;
      // Debug.Log("click");
      callEventClicked();
      Menu.SetActive(true);
      Menu.GetComponent<Menu>().Object = this.gameObject;
    }

    public void callEventClicked() {
      clicked.Invoke();
      Menu.GetComponent<Menu>().SetPos(this.gameObject);
    }

    public void callEventLooked() {
      looked.Invoke();     
    }

    public void callEventPicked() {
      picked.Invoke();
    }








    
}
