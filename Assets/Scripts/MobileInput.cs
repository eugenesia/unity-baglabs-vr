using UnityEngine;
using System.Collections;

public class MobileInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GvrViewer.Instance.Recenter();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount == 1 || Input.GetAxis("Vertical") > 0.0f) {
			// Get the player and camera objects.
			GameObject player = GameObject.FindGameObjectWithTag("Player");
			GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");

			Debug.Log(camera.transform.forward);

			// Change the character's position by moving in the direction that camera is facing.
			Vector3 direction = new Vector3(camera.transform.forward.x, 0, camera.transform.forward.z);
			player.transform.position = player.transform.position + direction;
		}

		// Update direction of debug pointer.
		//GameObject camera2 = GameObject.FindGameObjectWithTag("MainCamera");
		Camera camera2 = Camera.main;
		GameObject debugPtrParent = GameObject.FindGameObjectWithTag("DebugPointerParent");

		Vector3 direction2 = new Vector3(camera2.transform.forward.x, 0, camera2.transform.forward.z) * 1000;

		debugPtrParent.transform.rotation = Quaternion.LookRotation(direction2);
	}
}
