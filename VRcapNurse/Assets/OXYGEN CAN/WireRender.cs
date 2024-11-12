using UnityEngine;

public class WireRender : MonoBehaviour
{
    public Transform startPoint;  // The start point of the rope
    public Transform endPoint;    // The end point of the rope
    public LineRenderer lineRenderer;  // The Line Renderer component

    void Start()
    {
        // Initialize LineRenderer
        lineRenderer.positionCount = 2;  // Set two points for the line renderer
    }

    void FixedUpdate()
    {
        // Update the positions of the Line Renderer
        if (lineRenderer != null && startPoint != null && endPoint != null)
        {
            lineRenderer.SetPosition(0, startPoint.position);  // Start point position
            lineRenderer.SetPosition(1, endPoint.position);    // End point position
        }
    }
}
