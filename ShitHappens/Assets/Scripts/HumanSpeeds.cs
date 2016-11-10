using UnityEngine;
using System.Collections;

public class HumanSpeeds : MonoBehaviour {

    public GameObject[] Humans;

    public float movingSpeed = 5f;
    public float runnerSpeed = 10f;
    public float stoppedSpeed = 4f;

	void Start () {
        if (GetComponent<PoopOnHuman>() != null)
        {
            PoopOnHuman shat = GetComponent<PoopOnHuman>();
            shat.runnerShatOn = false;
        }
	}
	
	void Update () {

        if (gameObject == Humans[0])
        {
            if (GetComponent<PoopOnHuman>().runnerShatOn == false)
            {
                transform.Translate(Vector2.left * runnerSpeed * Time.deltaTime);
            }

            if (GetComponent<PoopOnHuman>().runnerShatOn == true)
            {
                transform.Translate(Vector2.left * stoppedSpeed * Time.deltaTime);
            }
        }

        if (gameObject == Humans[1])
        {
            transform.Translate(Vector2.left * movingSpeed * Time.deltaTime);
        }
        if (gameObject == Humans[2])
        {
            transform.Translate(Vector2.left * movingSpeed * Time.deltaTime);
        }
        if (gameObject == Humans[3])
        {
            transform.Translate(Vector2.left * movingSpeed * Time.deltaTime);
        }
        if (gameObject == Humans[4])
        {
            transform.Translate(Vector2.left * movingSpeed * Time.deltaTime);
        }
        if (gameObject == Humans[5])
        {
            transform.Translate(Vector2.left * movingSpeed * Time.deltaTime);
        }


        //Despawn humans
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);

            if (gameObject == Humans[0])
            {
                Destroy(Humans[0]);
            }
        }   
    }
   public void death()
    {
       movingSpeed = 0;
       runnerSpeed = 0;
}
}
