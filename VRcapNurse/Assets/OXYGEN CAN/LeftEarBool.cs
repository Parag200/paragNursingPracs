using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftEarBool : MonoBehaviour
{
    public bool LeftEarin = false;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("LeftEar"))
        {
            LeftEarin = true;

        }
    }
}
