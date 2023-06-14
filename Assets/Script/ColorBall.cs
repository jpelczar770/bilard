using UnityEngine;

public class ColorBall : MonoBehaviour
{
    public AudioSource uderzenie;
    public AudioSource stol;

    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "st�")
        {
            stol.Play();
        }

        if (collision.gameObject.tag == "pe�ne" || collision.gameObject.tag == "po��wki" || collision.gameObject.tag == "biala_bila"|| collision.gameObject.tag == "czarna_bila")
        {
            uderzenie.Play();
        }
    }
}