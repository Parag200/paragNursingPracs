using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScore : MonoBehaviour
{
    public CheckLOC CheckLOC;
    public connectIV connectIV;
    public BottomConnector BottomConnector;
    public sprayHIT sprayHIT;
    public SwapMats SwapMats;

    private int finalScore;
    public TextMesh textMesh;  // Reference to the TextMesh component

    void Start()
    {
        // Find the TextMesh component if not already assigned
        if (textMesh == null)
        {
            textMesh = GetComponent<TextMesh>();
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        finalScore = CheckLOC.ballScore + connectIV.IVscore + BottomConnector.OXYscore + sprayHIT.NitroScore + SwapMats.scoreNasal;
        Debug.Log(finalScore);
        // Display the number on the TextMesh
        if (textMesh != null)
        {
            textMesh.text = "Number: " + finalScore.ToString();
        }
    }
}
