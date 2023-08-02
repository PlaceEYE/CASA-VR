using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandControl : MonoBehaviour
{
    public Transform oculusController; // Reference to the Oculus OVR controller (usually OVRInput.Controller.RTouch or OVRInput.Controller.LTouch)
    public float minDistanceToShow = 1f;

    private Renderer objectRenderer;

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        if (objectRenderer == null)
        {
            Debug.LogError("HideObjectBasedOnDistance script requires a Renderer component on the GameObject.");
            enabled = false;
        }
    }

    private void Update()
    {
        if (oculusController == null)
        {
            Debug.LogError("Oculus Controller reference is missing.");
            return;
        }

        float distance = Vector3.Distance(transform.position, oculusController.position);

        if (distance <= minDistanceToShow)
        {
            objectRenderer.enabled = false;
            // isVisible = false;
        }
        else if (distance > minDistanceToShow)
        {
            objectRenderer.enabled = true;
            // isVisible = true;
        }
    }
}
