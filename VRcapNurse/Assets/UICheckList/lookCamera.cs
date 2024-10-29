using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookCamera : MonoBehaviour
{
    [SerializeField] private BillboardType billboardType;
   public enum BillboardType { LookAtCamera, CameraFoward};

    [SerializeField] private bool lockX;
    [SerializeField] private bool lockY;
    [SerializeField] private bool lockZ;

    private Vector3 ogROT;

    private void Awake()
    {
        ogROT = transform.rotation.eulerAngles;
    }

    private void LateUpdate()
    {
        switch (billboardType)
        {
            case BillboardType.LookAtCamera:
                transform.LookAt(Camera.main.transform.position, Vector3.up);
                break;
            case BillboardType.CameraFoward:
                transform.forward = Camera.main.transform.forward;
                break;
            default:
                break;
        }

        Vector3 rot = transform.rotation.eulerAngles;
        if (lockX) { rot.x = ogROT.x; }
        if (lockY) { rot.y = ogROT.y; }
        if (lockZ) { rot.z = ogROT.z; }
    }



}
