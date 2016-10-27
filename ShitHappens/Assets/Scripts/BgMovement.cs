using UnityEngine;
using System.Collections;

public class BgMovement : MonoBehaviour {


    public float speed;
    public float xMin;
    public float spawnX;

	void Update () {
        transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
        if (transform.position.x < xMin)
        {
            transform.position = new Vector3(spawnX, transform.position.y, transform.position.z);
        }
	}
}
