using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLOC : MonoBehaviour
{
    public GameObject ball;

    Vector3 ThreeLit = new Vector3(-0.548799992f, 1.489f, 1.107f);

    public int ballScore = 0;
    bool doneONCE = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position==ThreeLit && doneONCE == false)
        {
            ballScore = ballScore + 1;
            doneONCE = true;
        }
    }
}
