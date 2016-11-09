using UnityEngine;
using System.Collections;

public class HumanSpeeds : MonoBehaviour {

    public GameObject[] Humans;

    public float movingSpeed = 5f;
    public float runnerSpeed = 10f;

	void Start () {
	
	}
	
	void Update () {

        if (Humans[0])
        {
            transform.Translate(Vector2.left * runnerSpeed * Time.deltaTime);
        }

        //Despawn humans
        if (transform.position.x < -10f)
        {
            if (gameObject == Humans[0])
            {
                Destroy(Humans[0]);
                
            }

            /*if (gameObject == Humans[1])
            {
                Destroy(Humans[1]);
            }
            if (gameObject == Humans[2])
            {
                Destroy(Humans[2]);
            }*/
        }
    }
}
