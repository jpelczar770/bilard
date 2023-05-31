using UnityEngine;

public class Hole : MonoBehaviour
{
	public GameObject biala_bila;
    Vector2 zero = new Vector2 (0,0);

	void OnTriggerEnter2D(Collider2D other) {
	    if (other.tag == "bila")
	    {
	        Rigidbody2D rigid = other.GetComponent<Rigidbody2D>();
	        rigid.velocity = zero;
	        other.gameObject.SetActive(false);
		}

		if (other.tag == "biala_bila")
		{
		    Rigidbody2D rigid = other.GetComponent<Rigidbody2D>();
		    SpriteRenderer sprite = other.GetComponent<SpriteRenderer>();
		    CircleCollider2D collider = other.GetComponent<CircleCollider2D>();
	        rigid.velocity = zero;
	        sprite.enabled = false;
	        collider.enabled = false;
		}
	}


}