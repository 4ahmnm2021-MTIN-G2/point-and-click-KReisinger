using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Vector3 mousePos;
  
    public NavMeshAgent agent;
    private  Vector3 mouseCameraPos;

    public Camera cam;

    private bool movenabled = true;

    private Vector3 pos;

    private Vector3 newpos;


    public float lep;



    private Vector3 goal;
    void Start() {
        lep = 0;
    }
    void Update()
    {
        if(movenabled == false) {
            if(true) {
                lep += Time.deltaTime / 0.25f;
                if(lep > 1) {
                    if(goal == newpos) {
                        goal = pos;
                    } else {
                        goal = newpos;
                    }
                    lep = 0;
                }

            }
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
        } 
    }

    public void WinScene() {
        pos = this.gameObject.transform.position;
        newpos = new Vector3(pos.x, pos.y + 01.3f, pos.z);
        goal = newpos;
        StartCoroutine(DelayMenuLoad());
    }
    
    
    IEnumerator DelayMenuLoad()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
