using UnityEngine;
using System.Collections;

public class StandSpeed : MonoBehaviour {

    public float StandsSpeed = 4f;

    public GameObject[] stands;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * StandsSpeed * Time.deltaTime);

        if (transform.position.x < -15f)
        {
            Destroy(gameObject);

            if (gameObject == stands[0])
            {
                Destroy(stands[0]);
            }
        }
    }
}
