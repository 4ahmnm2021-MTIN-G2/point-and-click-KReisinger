using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject Object;

    public data DataSet;    

    void Start() {
        if(DataSet.key_Arbeitszimmer == true) {
            this.gameObject.transform.GetChild(3).GetChild(0).GetChild(1).gameObject.SetActive(true);
        }
            if(DataSet.key_Haustuere == true) {
            this.gameObject.transform.GetChild(3).GetChild(1).GetChild(1).gameObject.SetActive(true);
        }
    }



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
