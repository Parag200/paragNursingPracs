using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class connectIV : MonoBehaviour
{
    public bool conectIVin = false;
    public GameObject IV;

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("IV"))
        {
            conectIVin = true;
            IV.SetActive(false);

        }
    }

  
}