using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class manager_luz_tury : MonoBehaviour
{
    public string player1Tag;
    public string player2Tag;
    int wbite = 0;
    public Transform pozycja;
    public BallController_tury ref_BC;
    private string Kula_2;
    public bool wbitawruchu;
    public TMP_Text polowka_text;
    public TMP_Text cala_text;
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
            if (kula.tag == "pe³ne")
            { 
                Kula_2 = "po³ówki"; 
            }
            if (kula.tag == "po³ówki")
            {
                Kula_2 = "pe³ne";
            }
            if (ref_BC.liczba_inst % 2 != 0)
            {
                player2Tag = kula.tag;
                player1Tag = Kula_2;
                if (kula.tag == "pe³ne")
                {
                    polowka_text.text = PlayerPrefs.GetString("name1");
                    cala_text.text = PlayerPrefs.GetString("name2");
                }
                else if (kula.tag == "po³ówki")
                {
                    polowka_text.text = PlayerPrefs.GetString("name2");
                    cala_text.text = PlayerPrefs.GetString("name1");
                }
            }
            else if (ref_BC.liczba_inst % 2 == 0)
            {
                player1Tag = kula.tag;
                player2Tag = Kula_2;
                if (kula.tag == "pe³ne")
                {
                    polowka_text.text = PlayerPrefs.GetString("name2");
                    cala_text.text = PlayerPrefs.GetString("name1");
                }
                else if (kula.tag == "po³ówki")
                {
                    polowka_text.text = PlayerPrefs.GetString("name1");
                    cala_text.text = PlayerPrefs.GetString("name2");
                }
            }
        }

        wbite += 1;
        Vector3 p = pozycja.position;
        p.x = p.x + wbite * 3.0f;
        kula.transform.position = p;
    }


}
