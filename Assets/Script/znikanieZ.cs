using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class znikanieZ : MonoBehaviour
{
    public float disappearTime = 1f; // Set the time to disappear in seconds
    public float appearTime = 2f; // Set the time to appear in seconds
    public bool condition = false; // Set the condition to stop the disappearing and appearing
    private bool isVisible = true;
    public float timer = 0f;
    public SpriteRenderer kula;

    // Start is called before the first frame update
    void Start()
    {
        //kula = GetComponent<SpriteRenderer>();
        // Set the initial visibility of the game object
        kula.enabled = isVisible;
    }

    // Update is called once per frame
    void Update()
    {
        // Update the timer
        timer += Time.deltaTime;
        // Check if it's time to change the visibility of the game object
        if (isVisible && timer >= disappearTime)
        {
            // Make the game object invisible
            kula.enabled = false;
            isVisible = false;
            timer = 0f;
        }
        else if (!isVisible && timer >= appearTime)
        {
            // Make the game object visible
            kula.enabled = true;
            isVisible = true;
            timer = 0f;
        }

        // Check if the given condition is met
        if (condition)
        {
            // Stop the disappearing and appearing
            enabled = false;
        }
    }
}