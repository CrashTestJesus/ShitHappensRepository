using UnityEngine;
using System.Collections;

public class PoepBullet : MonoBehaviour {

    public GameObject bullet;

    public Transform pigeon;

    float movingSpeed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(bullet, transform.position, transform.rotation);
        }
        //transform.Translate(Vector2.down * movingSpeed * Time.deltaTime);

    }
}
