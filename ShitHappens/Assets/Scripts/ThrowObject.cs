﻿using UnityEngine;
using System.Collections;

public class ThrowObject : MonoBehaviour {

    public GameObject[] throwable;

    public float range;

    public float throwDelay;
    public float delayTillThrow;

    public float forwardForce;
    public float upwardForceMin;
    public float upwardForceMax;
    public float rotationForce;

    public Transform player;
    public Transform instantiatePoint;

    bool canThrow = true;
    bool shatOn;

    PoopOnHuman shat;

    Animator anim;
	
    void Start()
    {
        shat = GetComponent<PoopOnHuman>();
        anim = GetComponent<Animator>();
        player = GameObject.Find("Player").transform;
    }

	void Update () {
	 if(Vector3.Distance(transform.position, player.transform.position) < range && canThrow && !shat.shatOn)
        {
            anim.SetBool("throw", true);
            StartCoroutine(DelayTillThrow());
            canThrow = false;
        }
	}
    IEnumerator ThrowDelay()
    {
        yield return new WaitForSeconds(throwDelay);
        canThrow = true;
    }
    IEnumerator DelayTillThrow()
    {
        yield return new WaitForSeconds(delayTillThrow);    
        StartCoroutine(ThrowDelay());
        GameObject throwableObject = (GameObject)Instantiate(throwable[Random.Range(0, throwable.Length)], instantiatePoint.position, Quaternion.identity);
        Rigidbody2D rig = throwableObject.GetComponent<Rigidbody2D>();
        rig.velocity += new Vector2(-forwardForce, Random.Range(upwardForceMin, upwardForceMax)) * Time.deltaTime;
        rig.AddTorque(rotationForce);
        anim.SetBool("throw", false);
    }
}
