using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapMats : MonoBehaviour
{
    public GameObject list;

    public Material IvChecklist;
    public Material IvChecklistDONE;
    public Material NitroChecklistDONE;
    public Material ALLDONE;
    private Renderer objectRenderer;

    public connectIV connectIV;
    public sprayHIT sprayHIT;
    public LeftEarBool LeftEarBool;
    public RightEarBool RightEarBool;
    public NasalBool NasalBool;

    public bool isdone = false;


    private int x = 0;

    

    public int scoreNasal =0;
    // Start is called before the first frame update
    void Start()
    {
     
        // Get the Renderer component from the GameObject
        objectRenderer = GetComponent<Renderer>();
        // Set the initial material
        objectRenderer.material = IvChecklist;
    }

    // Update is called once per frame
    void Update()
    {

 
        if (connectIV.conectIVin==true)
        {
            objectRenderer.material = IvChecklistDONE;
        }

        if (sprayHIT.sprayNitro==true)
        {
            objectRenderer.material = NitroChecklistDONE;
        }
      
        if (NasalBool.Nasalin==true)
        {
            x = x + 1;
        }


        if (RightEarBool.RightEarin == true)
        {
            x = x + 1;
        }


        if (LeftEarBool.LeftEarin == true)
        {
            x = x + 1;
        }

        if (x>=2)
        {
            objectRenderer.material = ALLDONE;
            scoreNasal = 3;
            isdone = true;
        }

        


    }
}
