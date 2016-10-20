using UnityEngine;
using System.Collections;

public class HumanSpeeds : MonoBehaviour {

    public GameObject FemaleHuman;
    public GameObject MaleHuman;

    float movingSpeed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
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
