using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecklistFollow : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private float distance = 3.0f;

    private bool isCentered = false;

    public Material originalMaterial;
    public connectIV connectIV;
    private Renderer objectRenderer;

  
    public Material ivDone;
    public Material nasalDone;
    public Material oxyDone;
    public Material allDone;
    private void OnBecameInvisible()
    {
        isCentered = false;
    }
    private void Start()
    {
        objectRenderer = GetComponent<MeshRenderer>();
        originalMaterial = objectRenderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = FindTargetPosition();

        MoveTowards(targetPosition);

        if(ReachedPosition(targetPosition))
        {
            isCentered = true;
        }

        else if (connectIV.x==1)
        {
            objectRenderer.material = ivDone;
        }
    }

    private Vector3 FindTargetPosition()
    {
        return cameraTransform.position + (cameraTransform.forward * distance);
    }

    private void MoveTowards (Vector3 targetPosition)
    {
        transform.position += (targetPosition - transform.position) * 0.025f;
    }

    private bool ReachedPosition(Vector3 targetPosition)
    {
        return Vector3.Distance(targetPosition, transform.position) < 0.1f;
    }


}
