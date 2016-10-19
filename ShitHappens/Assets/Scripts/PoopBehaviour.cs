using UnityEngine;
using System.Collections;

public class PoopBehaviour : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("DestroyShit"))
        {
            Destroy(gameObject);
        }
    }
}
