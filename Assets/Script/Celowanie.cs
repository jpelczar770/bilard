using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celowanie : MonoBehaviour
{
    public Material material;
    public float startWidth = 0.2f;
    public float endWidth = 0.0f;
    public Color startColour = Color.white;
    public Color endColour = Color.clear;

    private LineRenderer lineRenderer;
    private Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        // Get a reference for our rigidbody, or add one if not present.
        rigidbody2D = GetComponent<Rigidbody2D>();
        if (rigidbody2D == null) {
            rigidbody2D = gameObject.AddComponent<Rigidbody2D>();
        }

        // Get a reference for our line renderer, or add one if not present.
        lineRenderer = GetComponent<LineRenderer>();
        if (lineRenderer == null) {
            lineRenderer = gameObject.AddComponent<LineRenderer>();
        }

        // Set the line renderer properties
        lineRenderer.enabled = false;
        lineRenderer.positionCount = 2;
        lineRenderer.material = material;
        lineRenderer.startWidth = startWidth;
        lineRenderer.endWidth = endWidth;
        lineRenderer.startColor = startColour;
        lineRenderer.endColor = endColour;
        lineRenderer.numCapVertices = 20;
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetMouseButtonDown(0)) {
        // We offset by forward so it's within the cameras viewpoint, else it wouldn't be rendered
        Vector3 startPos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + Vector3.forward;
        lineRenderer.SetPosition(0, startPos);
        lineRenderer.SetPosition(1, startPos);
        lineRenderer.enabled = true;
     }

     if (Input.GetMouseButton(0)) {
        Vector3 endPos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + Vector3.forward;
        lineRenderer.SetPosition(1, endPos);
     }

     if (Input.GetMouseButtonUp(0)) {
        // We've let go, so hide the drag line
        lineRenderer.enabled = false;

        // Add the force to the ball
        Vector3 inputForce = lineRenderer.GetPosition(0) - lineRenderer.GetPosition(1);
        rigidbody2D.AddForce(inputForce, ForceMode2D.Impulse);
     }
    }
}