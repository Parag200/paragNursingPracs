using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftEarBool : MonoBehaviour
{
    public bool LeftEarin = false;
    public Material newMaterial;  // Add a public Material variable to hold the new material
    public GameObject thisOBJ;

    

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("LeftEar"))
        {
            LeftEarin = true;
            // Change the material of the object that triggered the collider
            Renderer objRenderer = thisOBJ.gameObject.GetComponent<Renderer>();

            if (objRenderer != null)
            {
                objRenderer.material = newMaterial;  // Change the material to the new one
            }

        }
    }
}
