using UnityEngine;
using System.Collections;

public class HumanSpeeds : MonoBehaviour {

    public GameObject[] Humans;


    public float movingSpeed = 5f;

	void Start () {
	
	}
	
	void Update () {
        transform.Translate(Vector2.left * movingSpeed * Time.deltaTime);


        //Despawn humans
        if (transform.position.x < -10f)
        {
            if (gameObject == Humans[0])
            {
                Destroy(Humans[0]);
                
            }

            if (gameObject == Humans[1])
            {
                Destroy(Humans[1]);
            }
            if (gameObject == Humans[2])
            {
                Destroy(Humans[2]);
            }
        }
    }
}
