using UnityEngine;
using System.Collections;


public class BlinkScript : MonoBehaviour {

    Animator animator;

    float currTime;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
            currTime -= Time.deltaTime;
            if(currTime <= 0)
            {
                animator.SetBool("blink", true);
                StartCoroutine(Delay());               
            }        
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.1f);
        animator.SetBool("blink", false);
        currTime = Random.Range(2, 4);
    }
}

