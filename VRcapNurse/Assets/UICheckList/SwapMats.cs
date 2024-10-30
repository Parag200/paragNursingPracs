using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapMats : MonoBehaviour
{

    public Material current;
    public Material newMat;
    private Renderer objectRenderer;

    public connectIV connectIV;
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
        if (connectIV.x==1)
        {
            objectRenderer.material = newMat;
        }
    }
}
