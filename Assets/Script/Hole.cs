using UnityEngine;
using UnityEngine.UI;

public class Hole : MonoBehaviour
{
	public GameObject biala_bila;
    Vector2 zero = new Vector2 (0,0);
	public manager_luz_tury man;

	public BallController_tury ref_BC;
	void Start()
	{
		//luza = GetComponent<AudioSource>();
	}


	void OnTriggerEnter2D(Collider2D other) {
	    if (other.tag == "pe³ne" || other.tag == "po³ówki")
	    {
	        Rigidbody2D rigid = other.GetComponent<Rigidbody2D>();
	        rigid.velocity = zero;
			man.wbita(other.gameObject);
			if (ref_BC.turka == 0 && ((other.tag == "pe³ne" && man.player1Tag == "po³ówki") || (other.tag == "po³ówki" && man.player1Tag == "pe³ne")))
			{ ref_BC.turka = 1; }
			else if (ref_BC.turka == 1 && ((other.tag == "pe³ne" && man.player2Tag == "pó³owki") || (other.tag == "po³ówki" && man.player2Tag == "pe³ne")))
			{ ref_BC.turka = 0; }
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