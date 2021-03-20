using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public Vector3 mousePos;
    public Vector3 mouseCameraPos;

    void Update()
    {
        if (Input.GetMouseButton(0))  {
            mousePos = Input.mousePosition;
            mouseCameraPos = Camera.main.ScreenToWorldPoint(mousePos);
            this.transform.position = mouseCameraPos;
        }
    }
}
