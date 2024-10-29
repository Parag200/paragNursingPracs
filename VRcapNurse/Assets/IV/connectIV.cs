using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class connectIV : MonoBehaviour
{
    public int x = 0;
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("IV"))
        { 
            x = 1;
        }
    }

  
}