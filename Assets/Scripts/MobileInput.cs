using UnityEngine;
using System.Collections;

public class MobileInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount == 1 || Input.GetAxis("Vertical") > 0.0f) {
			// Get the player and camera objects.
			GameObject player = GameObject.FindGameObjectWithTag("Player");
			GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
			Debug.Log(camera.transform.forward);
			// Change the character's position by moving in the direction that camera is facing.
			player.transform.position = player.transform.position + camera.transform.forward;
		}
	}
}
