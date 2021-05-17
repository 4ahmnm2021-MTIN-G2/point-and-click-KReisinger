using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject Object;


    public void Ansehen() {
        Object.GetComponent<InteractableObject>().callEventLooked();
    }

    public void Aufheben() {
        Object.GetComponent<InteractableObject>().callEventPicked();
    }

    public void Schließen() {
        this.gameObject.SetActive(false);
    }

    public void SetPos(GameObject Interactable) {
        var pos = Interactable.transform.position;
        this.gameObject.transform.position = new Vector3(pos.x, pos.y + 3f, pos.z);
    }
}
