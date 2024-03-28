using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCol : MonoBehaviour    
{
    public Transform CameraAxis;
    public float wishDistance = 2;
   
    void Update()
    {
        var ray = (transform.position - CameraAxis.position).normalized;

        RaycastHit hit;
        if(Physics.Raycast(CameraAxis.position, ray, out hit, wishDistance))
        {
            if (hit.collider.gameObject)
            {
                transform.position = hit.point;
            }
           /* else
            {
                transform.position = CameraAxis.position + ray * wishDistance;
            }*/
        }
        else
        {
                transform.position = CameraAxis.position + ray * wishDistance;
        }
    }
}
