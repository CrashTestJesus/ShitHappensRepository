using UnityEngine;
using System.Collections;


public class BlinkScript : MonoBehaviour {

    Animator animator;
    bool runTimer;

    float currTime;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (runTimer)
        {
            currTime -= Time.deltaTime;
            if(currTime <= 0)
            {
                animator.SetBool("blink", true);
            }
        }
    }
    void SetUpTimer()
    {
        currTime = Random.Range(2, 4);

    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.1f);
        animator.SetBool("blink", false);
    }
}

