using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IVstartTask : MonoBehaviour
{
    public bool touchIV = false;
   
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Hands"))
        {
            touchIV = true;
        }
    }
}
