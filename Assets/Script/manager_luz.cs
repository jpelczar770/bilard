using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager_luz : MonoBehaviour
{
    int wbite = 0;
    public Transform pozycja;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void wbita(GameObject kula)
    {
        wbite += 1;
        Vector3 p = pozycja.position;
        p.x = p.x + wbite * 3.0f;
        kula.transform.position = p;
    }
}
