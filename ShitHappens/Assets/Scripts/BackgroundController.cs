using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour {

    public float speed = 4f;
    public float minX;
    public Vector3 spawnPos;

	
	void Update () {
        transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
        if (transform.position.x < minX)
        {
            transform.position = spawnPos;
        }
    }
}
