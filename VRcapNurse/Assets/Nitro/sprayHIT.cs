using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprayHIT : MonoBehaviour
{
    public bool sprayNitro = false;


    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.CompareTag("Mouth"))
        {
            sprayNitro = true;
        }
    }
}
