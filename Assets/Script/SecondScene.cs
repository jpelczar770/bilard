using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SecondScene : MonoBehaviour
{
    public TextMeshPro NameBox1;
    public TextMeshPro NameBox2;

    // Start is called before the first frame update
    void Start()
    {
        NameBox1.text = PlayerPrefs.GetString("name1");
        NameBox2.text = PlayerPrefs.GetString("name2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
