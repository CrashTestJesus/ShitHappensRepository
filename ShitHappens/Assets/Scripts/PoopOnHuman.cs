using UnityEngine;
using System.Collections;

public class PoopOnHuman : MonoBehaviour {

    public Sprite normal;
    public Sprite pooped;

    SpriteRenderer SpriteRenderer;

	// Use this for initialization
	void Start () {
        SpriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Shit"))
        {
            SpriteRenderer.sprite = pooped;
        }
    }
}
