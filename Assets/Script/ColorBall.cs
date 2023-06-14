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

        if (collision.gameObject.tag == "stó³")
        {
            stol.Play();
        }

        if (collision.gameObject.tag == "pe³ne" || collision.gameObject.tag == "po³ówki" || collision.gameObject.tag == "biala_bila"|| collision.gameObject.tag == "czarna_bila")
        {
            uderzenie.Play();
        }
    }
}