using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class manager_luz_tury : MonoBehaviour
{
    public string player1Tag;
    public string player2Tag;
    int wbite = 0;
    public Transform pozycja;
    public BallController_tury ref_BC;
    private string Kula_2;
    public bool wbitawruchu;
    //public TMP_Text polowka_text;
    //public TMP_Text cala_text;
    public GameObject polowka_gracz; 
    public GameObject cala_gracz;
    public Vector3 lewa = new Vector3(-19.95f, -16.3f, 0f);
    public Vector3 prawa = new Vector3(19.95f, -16.3f, 0f);

    /// <summary>
    /// ////////
    /// </summary>

    // Start is called before the first frame updatezdzc
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void wbita(GameObject kula)
    {
        wbitawruchu = true;
        if (wbite == 0)
        {
            if (kula.tag == "pe�ne")
            { 
                Kula_2 = "po��wki"; 
            }
            if (kula.tag == "po��wki")
            {
                Kula_2 = "pe�ne";
            }
            if (ref_BC.liczba_inst % 2 != 0)
            {
                player2Tag = kula.tag;
                player1Tag = Kula_2;
                if (kula.tag == "pe�ne")
                {
                 
                    polowka_gracz.transform.position = lewa;
                    cala_gracz.transform.position = prawa;
                }
                else if (kula.tag == "po��wki")
                {
                    polowka_gracz.transform.position = prawa;
                    cala_gracz.transform.position = lewa;
                }
            }
            else if (ref_BC.liczba_inst % 2 == 0)
            {
                player1Tag = kula.tag;
                player2Tag = Kula_2;
                if (kula.tag == "pe�ne")
                {
                    polowka_gracz.transform.position = prawa;
                    cala_gracz.transform.position = lewa;
                }
                else if (kula.tag == "po��wki")
                {
                    polowka_gracz.transform.position = lewa;
                    cala_gracz.transform.position = prawa;
                }
            }
        }

        wbite += 1;
        Vector3 p = pozycja.position;
        p.x = p.x + wbite * 3.0f;
        kula.transform.position = p;
    }


}
