using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IVwire : MonoBehaviour
{
    public GameObject[] _objs;

    public LineRenderer line;

    // Start is called before the first frame update
    void Start()
    {
        line = this.gameObject.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i=0; 1<_objs.Length;i++)
        {
            line.SetPosition(i,_objs[i].transform.position);
        }


    }
}
