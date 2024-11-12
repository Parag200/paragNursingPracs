using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightEarBool : MonoBehaviour
{
    public bool RightEarin = false;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("RightEar"))
        {
            RightEarin = true;

        }
    }
}