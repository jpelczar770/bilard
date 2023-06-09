using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class manager_luz : MonoBehaviour
{
    public string player1Tag;
    public string player2Tag;
    public string ballTag;
    public BallController refBC;

    int wbite = 0;
    public Transform pozycja;

    // Start is called before the first frame updatezdzc
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AssignBallToCurrentPlayer(GameObject ball)
    {

        // Perform any other necessary actions for assigning the ball to the player
        if (ball.tag == "cala")
        { ballTag = "half"; }
        else if (ball.tag == "half")
        { ballTag = "cala"; }

        if (refBC.liczba_inst % 2 != 0)
        {
            player1Tag = ball.tag;
            player2Tag = ballTag;
        }
        else if (refBC.liczba_inst % 2 == 0)
        {
            player2Tag = ball.tag;
            player1Tag = ballTag;
        }
    }

    public void wbita(GameObject kula)
    {
        if (wbite == 0)
        { AssignBallToCurrentPlayer(kula); }

        wbite += 1;
        Vector3 p = pozycja.position;
        p.x = p.x + wbite * 3.0f;
        kula.transform.position = p;
    }
}
