using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class znikanie : MonoBehaviour
{
    public float disappearTime = 0.5f; // Set the time to disappear in seconds
    public float appearTime = 1f; // Set the time to appear in seconds
    public bool condition = false; // Set the condition to stop the disappearing and appearing
    public bool[] isVisible;
    public float[] timer;
    public GameObject[] kula;

    // Start is called before the first frame update
    void Start()
    {
        isVisible = new bool[] { false, false, false };
        timer = new float[] { 2/3f, 1/3f, 0f };
        //kula = GetComponent<SpriteRenderer>();
        // Set the initial visibility of the game object

        for (int i = 0; i < timer.Length; i++) {
            kula[i].SetActive(isVisible[i]);
            }
    }

    // Update is called once per frame
    void Update()
    {
        // Update the timer
        for (int i = 0; i < timer.Length; i++) 
        {
            timer[i] += Time.deltaTime;
            // Check if it's time to change the visibility of the game object
            if (isVisible[i] && timer[i] >= disappearTime)
            {
                // Make the game object invisible
                kula[i].SetActive(false);
                isVisible[i] = false;
                timer[i] = 0f;
            }
            else if (!isVisible[i] && timer[i] >= appearTime)
            {
                // Make the game object visible
                kula[i].SetActive(true);
                isVisible[i] = true;
                timer[i] = 0f;
            }
        }
    }
}
