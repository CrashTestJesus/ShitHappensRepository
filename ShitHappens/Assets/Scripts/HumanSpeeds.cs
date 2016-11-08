using UnityEngine;
using System.Collections;

public class HumanSpeeds : MonoBehaviour {

    public GameObject FemaleHuman;
    public GameObject MaleHuman;

    public float movingSpeed = 5f;

	void Start () {
	
	}
	
	void Update () {
        transform.Translate(Vector2.left * movingSpeed * Time.deltaTime);


        //Despawn humans
        if (transform.position.x < -10f)
        {
            if (gameObject == MaleHuman)
            {
                Destroy(MaleHuman);
            }

            if (gameObject == FemaleHuman)
            {
                Destroy(FemaleHuman);
            }
        }
    }
}
