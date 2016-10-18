using UnityEngine;
using System.Collections;

public class PoopingScript : MonoBehaviour {

    public GameObject bullet;
    public GameObject poop;

    public Transform pigeon;

    public int ammunition = 5;

    bool canShit = true;



    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (canShit == true)
        {
            if (Input.GetButtonDown("Shit") && poop == null)
            {
                poop = (GameObject)Instantiate(bullet, transform.position, transform.rotation);
                poop.transform.position = new Vector3(pigeon.position.x, 1.5f, 0f);
                ammunition = ammunition - 1;
            }
        }
        if (ammunition == 0)
        {
            canShit = false;
        }
    }
}
