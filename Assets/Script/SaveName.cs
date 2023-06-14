using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SaveName: MonoBehaviour
{
    public TMP_InputField textBox1;
    public TMP_InputField textBox2;

    public void clickSaveButton()
    {
        PlayerPrefs.SetString("name1",textBox1.text);
        PlayerPrefs.SetString("name2", textBox2.text);
        Debug.Log("Your Name is " + PlayerPrefs.GetString("name1"));
        Debug.Log("Your Name is " + PlayerPrefs.GetString("name2"));
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
