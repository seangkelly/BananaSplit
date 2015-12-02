using UnityEngine;
using System.Collections;

public class ScreenShake : MonoBehaviour {

	Vector3 startPos;
	public float shakeStrength = 0f;

	// Use this for initialization
	void Start () {
		startPos = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 offsetVector = transform.right * Mathf.Sin (Time.time *50f)
			+ transform.up * Mathf.Sin (Time.time * 43f);
	


		transform.position = startPos + offsetVector;

		if (Input.GetKeyDown(KeyCode.Space))
		{
			shakeStrength = 0.4f;
		}

		shakeStrength = Mathf.Clamp (shakeStrength - Time.deltaTime, 0f, 1f);
	}
}
