using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapMats : MonoBehaviour
{

    public Material current;
    public Material IVcheck;
    public Material NitroCheck;
    public Material NitroIVCheck;
    private Renderer objectRenderer;

    public connectIV connectIV;
    public sprayHIT sprayHIT;
    // Start is called before the first frame update
    void Start()
    {
        // Get the Renderer component from the GameObject
        objectRenderer = GetComponent<Renderer>();
        // Set the initial material
        objectRenderer.material = current;
    }

    // Update is called once per frame
    void Update()
    {
        if (connectIV.conectIVin == true)
        {
            objectRenderer.material = IVcheck;
        }

        if (sprayHIT.sprayNitro == true)
        {
            objectRenderer.material = NitroCheck;
        }

        if (connectIV.conectIVin == true && sprayHIT.sprayNitro == true)
        {
            objectRenderer.material = NitroIVCheck;
        }
    }
}
