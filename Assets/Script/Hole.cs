using UnityEngine;
using UnityEngine.UI;

public class Hole : MonoBehaviour
{
	public GameObject biala_bila;
    Vector2 zero = new Vector2 (0,0);
	public manager_luz man;
    public AudioSource luza;

    void Start() {
    luza = GetComponent<AudioSource>();
    }

	void OnTriggerEnter2D(Collider2D other) {
	    if (other.tag == "pełne" | other.tag == "połówki")
	    {
	        Rigidbody2D rigid = other.GetComponent<Rigidbody2D>();
	        rigid.velocity = zero;
			man.wbita(other.gameObject);
            luza.Play();
		}

		if (other.tag == "biala_bila")
		{
		    Rigidbody2D rigid = other.GetComponent<Rigidbody2D>();
		    SpriteRenderer sprite = other.GetComponent<SpriteRenderer>();
		    CircleCollider2D collider = other.GetComponent<CircleCollider2D>();
	        rigid.velocity = zero;
	        sprite.enabled = false;
	        collider.enabled = false;
	        luza.Play();
		}
	}

}