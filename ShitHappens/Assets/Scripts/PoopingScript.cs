using UnityEngine;
using System.Collections;

public class PoopingScript : MonoBehaviour {

    public GameObject bullet;
    public GameObject poop;

    public Transform pigeon;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Shit") && poop == null)
        {
            poop = (GameObject)Instantiate(bullet, transform.position, transform.rotation);
            poop.transform.position = new Vector3(pigeon.position.x, 1.5f, 0f);
        }
    }
}
