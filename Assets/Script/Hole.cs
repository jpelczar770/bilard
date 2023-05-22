using UnityEngine;

public class Hole : MonoBehaviour
{
	public GameObject Bile_kolorowe;
	public GameObject biala_bila;

	private Vector2 originalCueBallPosition;

	void Start() {
		originalCueBallPosition = biala_bila.transform.position;
	}

	void OnCollisionEnter(Collision collision) {
		foreach (var transform in Bile_kolorowe.GetComponentsInChildren<Transform>()) {
			if (transform.name == collision.gameObject.name) {
				var objectName = collision.gameObject.name;
				GameObject.Destroy(collision.gameObject);

				var ballNumber = int.Parse(objectName.Replace("Ball", ""));
			}
		}

		if (biala_bila.transform.name == collision.gameObject.name) {
			biala_bila.transform.position = originalCueBallPosition;
		}
	}
}