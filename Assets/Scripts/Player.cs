using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Player : MonoBehaviour
{
    private Vector3 mousePos;

    public NavMeshAgent agent;
    private  Vector3 mouseCameraPos;

    public Camera cam;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))  {

            var ray  = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit)) {
                agent.SetDestination(hit.point);
            }



            // mousePos = Input.mousePosition;
            // mouseCameraPos = Camera.main.ScreenToWorldPoint(mousePos);
            // this.transform.position = mouseCameraPos;
        
            // Debug.Log(Input.mousePosition.y);

            // var scalefak = Input.mousePosition.y / 100;

            // var scale = CalcScale(Input.mousePosition.y);
  
            // this.transform.localScale = new Vector3(0.6f + scale, 0.6f + scale, 0.6f+ scale);


        }

        // float CalcScale(float pos) {
            
        //     var scale = pos / 200;
        //     return scale * -1;
        // }

    }
}
