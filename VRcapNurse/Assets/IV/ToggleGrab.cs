using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ToggleGrab : MonoBehaviour
{
    public connectIV connectIV;
    public GameObject IVConnectCOL;
    public XRGrabInteractable grabInteractable;
    public bool isGrabbable = true; // This will control the grabbability

    private void Awake()
    {
        if (grabInteractable == null)
        {
            grabInteractable = GetComponent<XRGrabInteractable>();
        }
    }

    private void Update()
    {
        // Example: toggle isGrabbable for testing (you can set it based on your conditions)
        if (connectIV.conectIVin ==true)
        {
            isGrabbable = !isGrabbable;

            UpdateGrabbability();
        }
    }

    public void UpdateGrabbability()
    {
        grabInteractable.interactionLayerMask = isGrabbable ? LayerMask.GetMask("Grab") : LayerMask.GetMask("Ignore Raycast");
    }

}
