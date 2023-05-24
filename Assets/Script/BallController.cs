using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public Material material;
    public float startWidth = 0.2f;
    public float endWidth = 0.0f;
    public Color startColour = Color.white;
    public Color endColour = Color.clear;

    private LineRenderer lineRenderer;

    [SerializeField] GameObject bialaBila = null;
    [SerializeField] float power = 20f;
    [SerializeField] Transform arrow = null;
    [SerializeField] List<ColorBall>ballList = new List<ColorBall>();

    Vector2 mousePosition = new Vector3();
    Rigidbody2D bialaRigid = null;
    Vector2 bialaBilaDefaultPosition = new Vector2();

    // Start is called before the first frame update
    void Start()
    {
        bialaRigid = bialaBila.GetComponent<Rigidbody2D>();
        bialaBilaDefaultPosition = bialaBila.transform.localPosition;
        arrow.gameObject.SetActive(false);

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
        if (bialaBila.activeSelf == true)
        {
            if (Input.GetMouseButtonDown(0) == true)
            {
                mousePosition = Input.mousePosition;
                arrow.gameObject.SetActive(true);
                Debug.Log("Click started");
                Vector3 startPos = bialaBila.transform.localPosition + Vector3.forward;
                lineRenderer.SetPosition(0, startPos);
                lineRenderer.SetPosition(1, startPos);
                lineRenderer.enabled = true;
            }

            if (Input.GetMouseButton(0) == true)
            {
                Vector2 position = Input.mousePosition;

                Vector2 def = mousePosition - position;
                float rad = Mathf.Atan2(def.x, def.y);
                float angle = rad*Mathf.Rad2Deg;
                Vector3 rot = new Vector3(0, angle, 0);
                Quaternion qua = Quaternion.Euler(rot);

                arrow.localRotation = qua;
                arrow.transform.position = bialaBila.transform.position;

                Vector3 endPos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + Vector3.forward;
                lineRenderer.SetPosition(1, endPos);

            }

            if (Input.GetMouseButtonUp(0) == true)
            {
                Vector2 upPosition = Input.mousePosition;

                Vector2 def = mousePosition - upPosition;
                Vector2 add = new Vector2(def.x, def.y);

                bialaRigid.AddForce(add*power);
                arrow.gameObject.SetActive(false);

                Debug.Log("Finish clicking");

                // We've let go, so hide the drag line
                lineRenderer.enabled = false;
            }
        }
    }
}
