using UnityEngine;
using System.Collections;

public class DuifMoving : MonoBehaviour {

    float movingSpeed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * movingSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * movingSpeed * Time.deltaTime);
        }
    }
}
