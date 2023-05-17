using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private GameObject bialaBila = null;
    [SerializeField] private float power = 0.1f;
    [SerializeField] private Transform arrow = null;
    [SerializeField] private List<ColorBall>ballList = new List<ColorBall>();

    private Vector2 mousePosition = Vector2.zero;
    private Rigidbody2D bialaRigid = null;
    private Vector2 bialaBilaDefaultPosition = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        bialaRigid = bialaBila.GetComponent<Rigidbody2D>();
        bialaBilaDefaultPosition = bialaBila.transform.position;
        arrow.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (bialaBila.activeSelf == true)
        {
            if (Input.GetMouseButtonDown(0) == true)
            {
                mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                arrow.gameObject.SetActive(true);
                Debug.Log("Click started");
            }

            if (Input.GetMouseButton(0) == true)
            {
                Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                Vector2 direction = mousePosition - position;
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                Vector2 rotation = new Vector2(0,angle);
                Quaternion qua = Quaternion.Euler(rotation);

                arrow.rotation = qua;
                arrow.position = bialaBila.transform.position;
            }

            if (Input.GetMouseButtonUp(0) == true)
            {
                Vector2 upPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                Vector2 direction = mousePosition - upPosition;
                Vector2 force = new Vector2(direction.x, direction.y) * power;

                bialaRigid.AddForce(force);
                arrow.gameObject.SetActive(false);

                Debug.Log("Finish clicking");
            }
        }
    }
}
