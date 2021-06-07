using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;


public class Player : MonoBehaviour
{
    private Vector3 mousePos;
  
    public NavMeshAgent agent;
    private  Vector3 mouseCameraPos;

    public Camera cam;

    private bool movenabled = true;

    private Vector3 pos;

    private Vector3 newpos;

    private float t; 

    public float lep;

    private bool hb = true;
    private bool ht = false;

    private Vector3 goal;
    void Start() {
        lep = 0;
    }
    void Update()
    {
        if(movenabled == false) {
            if(true) {
                lep += Time.deltaTime / 0.3f;
                if(lep > 1) {
                    ht = true; 
                    hb = false;
                    if(goal == newpos) {
                        goal = pos;
                    } else {
                        goal = newpos;
                    }
                    lep = 0;
                }

            }
   
            Debug.Log(lep);
            this.gameObject.transform.position = Vector3.Lerp(this.gameObject.transform.position , goal, lep);
            


        }
        if (Input.GetMouseButtonDown(0))  {
       
            var ray  = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit) && movenabled == true) {
                agent.SetDestination(hit.point);
            }
        }
    }

    public void ToggleMovement() {
        if(movenabled == true) {
            agent.enabled = false;
            movenabled = false;
            WinScene();
        } else {
            // agent.enabled = true;
            // movenabled = true;
        }
    }

    public void WinScene() {
        pos = this.gameObject.transform.position;
        newpos = new Vector3(pos.x, pos.y + 01.5f, pos.z);
        goal = newpos;
    
    }
}
