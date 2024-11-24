using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprayHIT : MonoBehaviour
{
    public bool sprayNitro = false;
    public GameObject NitroSphere;


    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.CompareTag("Mouth"))
        {
            sprayNitro = true;
            NitroSphere.SetActive(false);
        }

        if (other.gameObject.CompareTag("MouthWrong"))
        {
            sprayNitro = false;
            NitroSphere.SetActive(false);
        }
    }
}
