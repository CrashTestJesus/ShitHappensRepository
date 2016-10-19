using UnityEngine;
using System.Collections;

public class HumanSpeeds : MonoBehaviour {

    float movingSpeed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.left * movingSpeed * Time.deltaTime);
	}
}
