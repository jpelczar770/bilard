using UnityEngine;

public class ColorBall : MonoBehaviour
{
    public AudioSource uderzenie;
    public AudioSource stol;

     void Start()
    {
        uderzenie = GetComponent<AudioSource>();
        stol = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision) {

	    if (collision.gameObject.tag == "stół")
	    {
            stol.Play();
		}

		if (collision.gameObject.tag == "pełne" | collision.gameObject.tag == "połówki" | collision.gameObject.tag == "biala_bila")
	    {
            uderzenie.Play();
		}
	}
}