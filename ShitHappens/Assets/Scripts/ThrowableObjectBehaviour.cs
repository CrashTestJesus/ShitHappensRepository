using UnityEngine;
using System.Collections;

public class ThrowableObjectBehaviour : MonoBehaviour {

    void Update()
    {
        if(transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("DestroyShit"))
        {
            Destroy(gameObject, 0.5f);
        }
    }
}
