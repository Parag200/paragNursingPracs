using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerGrab : MonoBehaviour
{
    Material m_Material;
    public Material baseColor;
    public Material holdColor;

   

    // Start is called before the first frame update
    void Start()
    {
       m_Material = GetComponent<Renderer>().material;
       m_Material = baseColor;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Box")
        {
            m_Material = holdColor;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Box")
        {
            m_Material = baseColor;
        }
    }
}
