using UnityEngine;
using System.Collections;

public class RunnerScript : MonoBehaviour {

    public Sprite[] Runner;

    SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
