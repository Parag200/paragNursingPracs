using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NasalBool : MonoBehaviour
{
    public bool Nasalin = false;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Nasal"))
        {
           Nasalin = true;

        }
    }
}