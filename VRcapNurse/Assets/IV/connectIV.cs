using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class connectIV : MonoBehaviour
{
    public int x = 0;
    private void OnTriggerEnter(Collider other)
    {
        XRGrabInteractable iv = other.GetComponent<XRGrabInteractable>();

        if (other.gameObject.CompareTag("IV"))
        {
            // If the IV (cube) enters the socket, disable grabbing
            iv.interactionLayers = LayerMask.GetMask("Nothing"); // Effectively prevents interaction
            x = 1;
        }
    }

  
}