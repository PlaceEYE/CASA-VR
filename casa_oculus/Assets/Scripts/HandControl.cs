using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandControl : MonoBehaviour
{
    GameObject controllerL;
    GameObject controllerR;
    GameObject controllerH;
    public GameObject obj;

    private void Start()
    {
        controllerH = GameObject.Find("OVRCameraRig");
        controllerL = GameObject.Find("LeftHandAnchor");
        controllerR = GameObject.Find("RightHandAnchor");
    }

        private void Update()
    {
        float distanceL = Vector3.Distance(controllerL.transform.position, obj.transform.position);
        float distanceR = Vector3.Distance(controllerR.transform.position, obj.transform.position);
        float distanceH = Vector3.Distance(controllerH.transform.position, obj.transform.position);
        Debug.Log("distance between L is " + distanceL);
        Debug.Log("distance between R is " + distanceR);
        Debug.Log("distance between H is " + distanceH);

        if (distanceL < 2.2f)
        {
            Debug.Log("non active");
            obj.SetActive(false);
        }
        else
        {
            Debug.Log("active");
            obj.SetActive(true);
        }
    }
}
