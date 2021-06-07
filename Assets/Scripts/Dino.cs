using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino : MonoBehaviour
{
    // Start is called before the first frame update

    public data DataSet;
    public Manager manager;

    public GameObject Sausia;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DocPicked() {

    }

    void OnMouseDown() {
        if(DataSet.peppa == false && DataSet.tree == false) {
            manager.SetNotification("Sprich zuerst mit Peppa vielleicht weiß sie mehr");
        }
        if(DataSet.tree == false && DataSet.peppa == true) {
            manager.SetNotification("Schaue zuerst ob Peppa recht hatte und der Dino draußen ist");
        }

        if(DataSet.tree == true && DataSet.peppa == true) {
            manager.SetNotification("Du hast Sausia entlich gefunden");
            var Schorsch =  GameObject.Find("schorsch");
            Schorsch.transform.GetComponent<Player>().ToggleMovement();
            Sausia.transform.parent = Schorsch.transform;
            Sausia.transform.localPosition = new Vector3(1f,0f,0f);
            Sausia.SetActive(true);
        }
    }
}
