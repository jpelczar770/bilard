using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hole : MonoBehaviour
{
	public GameObject biala_bila;
    Vector2 zero = new Vector2 (0,0);
	public manager_luz_tury man;
	public AudioSource luza;

	public BallController_tury ref_BC;
	void Start()
	{
		luza = GetComponent<AudioSource>();
	}

	void OnTriggerEnter2D(Collider2D other) {
	    if (other.tag == "pe�ne" || other.tag == "po��wki")
	    {
	        Rigidbody2D rigid = other.GetComponent<Rigidbody2D>();
	        rigid.velocity = zero;
			man.wbita(other.gameObject);
			luza.Play();
			if (ref_BC.turka == 0 && ((other.tag == "pe�ne" && man.player1Tag == "po��wki") || (other.tag == "po��wki" && man.player1Tag == "pe�ne")))
			{ ref_BC.turka = 1; }
			else if (ref_BC.turka == 1 && ((other.tag == "pe�ne" && man.player2Tag == "p�owki") || (other.tag == "po��wki" && man.player2Tag == "pe�ne")))
			{ ref_BC.turka = 0; }
		}

		if (other.tag == "biala_bila")
		{
		    Rigidbody2D rigid = other.GetComponent<Rigidbody2D>();
		    SpriteRenderer sprite = other.GetComponent<SpriteRenderer>();
		    CircleCollider2D collider = other.GetComponent<CircleCollider2D>();
			luza.Play();
			rigid.velocity = zero;
	        sprite.enabled = false;
	        collider.enabled = false;
		}

		if (other.tag == "czarna_bila")
		{
			luza.Play();
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}

}