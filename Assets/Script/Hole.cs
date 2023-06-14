using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hole : MonoBehaviour
{
	public GameObject biala_bila;
    Vector2 zero = new Vector2 (0,0);
	public manager_luz_tury man;
	public AudioSource luza;
	public bool wbitaprzeciwna;
	public bool czypierwsza;

	public BallController_tury ref_BC;
	void Start()
	{
		
	}

	void OnTriggerEnter2D(Collider2D other) {
	    if (other.tag == "pe�ne" || other.tag == "po��wki")
	    {
	        Rigidbody2D rigid = other.GetComponent<Rigidbody2D>();
	        rigid.velocity = zero;
			man.wbita(other.gameObject);
			luza.Play();
			if (ref_BC.turka == 0 && ((other.tag == "pe�ne" && man.player1Tag == "po��wki") || (other.tag == "po��wki" && man.player1Tag == "pe�ne")) && wbitaprzeciwna == false && czypierwsza)
			{
				ref_BC.turka = 1;
				wbitaprzeciwna = true;
				czypierwsza = false;
			}
			else if (ref_BC.turka == 1 && ((other.tag == "pe�ne" && man.player2Tag == "p�owki") || (other.tag == "po��wki" && man.player2Tag == "pe�ne")) && wbitaprzeciwna == false && czypierwsza)
			{
				ref_BC.turka = 0;
				wbitaprzeciwna = true;
				czypierwsza = false;
			}
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
			if (ref_BC.turka == 0 && wbitaprzeciwna == false)
			{
				ref_BC.turka = 1;
				wbitaprzeciwna = true;
				man.wbitawruchu = true;
			}
			else if (ref_BC.turka == 1 && wbitaprzeciwna == false)
			{
				ref_BC.turka = 0;
				wbitaprzeciwna = true;
				man.wbitawruchu = true;
			}
		}

		if (other.tag == "czarna_bila")
		{
			luza.Play();
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}

}