using UnityEngine;

public class Hole : MonoBehaviour
{
	public GameObject biala_bila;

    public Vector3 position = new Vector3 (-11,0,-0.5f);

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "bila") {
		    Debug.Log("Hit: " + other.transform.name);
		    other.gameObject.SetActive(false);
		    Debug.Log(other.gameObject);
		}

		if (other.gameObject.name == "biala_bila") {
		    Instantiate(biala_bila, position, Quaternion.identity);
	        other.gameObject.SetActive(false);
		}

	}
}