using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputMan : MonoBehaviour
{
    [SerializeField]
    private Camera sceneCam;

    private Vector3 lastPos;

    [SerializeField]
    private LayerMask placMask; 

    public Vector3 GetSelectedMapPosition()
    {
        Vector3 MousePos = Input.mousePosition;

        //cannot select unrendered things by cam
        MousePos.z = sceneCam.nearClipPlane;
        Ray ray = sceneCam.ScreenPointToRay(MousePos);
        RaycastHit hit;

        //detects what's hit
        if (Physics.Raycast(ray, out hit, 100, placMask))
        {
            lastPos = hit.point;
        }
        return lastPos; 
    }
}
