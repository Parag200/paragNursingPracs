using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomConnector : MonoBehaviour
{
    public bool conectOXY = false;
    public GameObject oxybottom;
    public Material newMaterial;  // Add a public Material variable to hold the new material

    public int OXYscore = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bottom"))
        {
            OXYscore = OXYscore + 1;
            conectOXY = true; 

            // Change the material of the object that triggered the collider
            Renderer objRenderer = oxybottom.gameObject.GetComponent<Renderer>();

            if (objRenderer != null)
            {
                objRenderer.material = newMaterial;  // Change the material to the new one
            }
        }
    }
}
