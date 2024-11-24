using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class connectIV : MonoBehaviour
{
    public bool conectIVin = false;
    public GameObject IV;
    public Material newMaterial;  // Add a public Material variable to hold the new material

    public int IVscore = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("IV"))
        {
            IVscore = IVscore + 1;
            conectIVin = true;

            // Change the material of the object that triggered the collider
            Renderer objRenderer = IV.gameObject.GetComponent<Renderer>();

            if (objRenderer != null)
            {
                objRenderer.material = newMaterial;  // Change the material to the new one
            }
        }
    }
}
