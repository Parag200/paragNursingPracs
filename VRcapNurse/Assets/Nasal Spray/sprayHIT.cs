using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprayHIT : MonoBehaviour
{
    public bool sprayNitro = false;
    public GameObject NitroSphere;
    public Material newMaterial;  // Add a public Material variable to hold the new material
    public GameObject thisOBJ;

    public int NitroScore = 0;

    bool doneONCE = false;

    private void OnParticleCollision(GameObject other)
    {
    
        if (other.gameObject.CompareTag("Mouth") &&  doneONCE==false)
        {
            NitroScore = NitroScore + 1;
            sprayNitro = true;
            NitroSphere.SetActive(false);
            doneONCE = true;
        }

        if (other.gameObject.CompareTag("MouthWrong"))
        {
            NitroScore = 0;
            sprayNitro = false;
            NitroSphere.SetActive(false);
        }

        // Change the material of the object that triggered the collider
        Renderer objRenderer = thisOBJ.gameObject.GetComponent<Renderer>();

        if (objRenderer != null)
        {
            objRenderer.material = newMaterial;  // Change the material to the new one
        }
    }
}
