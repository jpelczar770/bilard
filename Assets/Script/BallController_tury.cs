using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BallController_tury : MonoBehaviour
{
    public TMP_Text gracz_text;
    public string player;
    public int liczba_inst = 0;
    public Material material;
    public float startWidth = 0.2f;
    public float endWidth = 0.0f;
    public Color startColour = Color.white;
    public Color endColour = Color.clear;
    public Vector3 respawnposition = new Vector3(-11, 0, -0.5f);
    public AudioSource kij;

    public manager_luz_tury man;
    public bool przed_ruchem;

    /// <summary>
    /// //////////////
    /// </summary>
    public int turka;

    private LineRenderer lineRenderer;

    [SerializeField] GameObject bialaBila = null;
    [SerializeField] float power = 30f;
    [SerializeField] Transform arrow = null;
    [SerializeField] List<Rigidbody2D>ballList = new List<Rigidbody2D>();

    Vector2 mousePosition = new Vector2();
    Vector2 zero = new Vector2(0, 0);
    Rigidbody2D bialaRigid = null;
    SpriteRenderer sprite = null;
    CircleCollider2D collider = null;
    Vector2 bialaBilaDefaultPosition = new Vector2();
    public int kot;

    public void Tura(int tura)
    {
        turka = tura;
        if (tura == 0)
            { 
                    player = "player1";
             }
            else if (tura == 1)
        {
                 player = "player2";
        }
        gracz_text.text = player;
    }
    

    // Start is called before the first frame update
    void Start()
    {
        przed_ruchem = true;
        gracz_text.text = "player2";
        turka = 1;
        // Display the capture text with the player's name

        bialaRigid = bialaBila.GetComponent<Rigidbody2D>();
        sprite = bialaBila.GetComponent<SpriteRenderer>();
        collider = bialaBila.GetComponent<CircleCollider2D>();
        bialaBilaDefaultPosition = bialaBila.transform.localPosition;
        arrow.gameObject.SetActive(false);

        // Get a reference for our line renderer, or add one if not present.
        lineRenderer = GetComponent<LineRenderer>();
        if (lineRenderer == null)
        {
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
        bool bilewruchu = false;
        foreach (Rigidbody2D bila in ballList)
        {
           if (bila.velocity.magnitude < 1.25)
            {
                bila.velocity = zero;
            }
            else
            {
                bilewruchu = bilewruchu | true;
            }
        }

        if (bialaBila.activeSelf == true)
        {

            if (bialaRigid.velocity.magnitude < 1.25)
            {
                bialaRigid.velocity = zero;
            }
            else
            {
                bilewruchu = bilewruchu | true;
            }

                if (!bilewruchu)
                {
                kot += 1;
                Debug.Log(turka);
                Tura(turka);
                if (man.wbitawruchu == false && kot == 5 && liczba_inst != 0)
                {
                    if (turka == 0)
                    { Tura(1); }
                    else if (turka == 1)
                    { Tura(0); }
                }
                if (Input.GetMouseButtonDown(0) == true)
                    {
                        mousePosition = Input.mousePosition;
                        arrow.gameObject.SetActive(true);
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
                    { //puszczenie kijka
                    kot = 0;
                        liczba_inst += 1;
                        man.wbitawruchu = false;

                        
                        Vector2 upPosition = Input.mousePosition;

                        Vector2 def = mousePosition - upPosition;
                        Vector2 add = new Vector2(def.x, def.y);

                        bialaRigid.AddForce(add*power);
                        arrow.gameObject.SetActive(false);

                        lineRenderer.enabled = false;
                        kij.Play();
                }
                }

        }

        if (!sprite.enabled & !bilewruchu)
        {
            bialaBila.transform.position = respawnposition;
            sprite.enabled = true;
            collider.enabled = true;
        }

    }
    
}
