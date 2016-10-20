using UnityEngine;
using System.Collections;

public class ShitAnimation : MonoBehaviour {

    public Sprite[] shit;

    SpriteRenderer SpriteRenderer;

	// Use this for initialization
	void Start () {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        SpriteRenderer.sprite = shit[0];
        
        if (shit[0])
        {
            StartCoroutine(SpriteDelay());
        }
        SpriteRenderer.sprite = shit[1];

        if (shit[1])
        {
            StartCoroutine(SpriteDelay());
        }
        SpriteRenderer.sprite = shit[2];

        if (shit[2])
        {
            StartCoroutine(SpriteDelay());
        }
        SpriteRenderer.sprite = shit[3];

        if (shit[3])
        {
            StartCoroutine(SpriteDelay());
        }
        SpriteRenderer.sprite = shit[4];
    }

    IEnumerator SpriteDelay()
    {
        yield return new WaitForSeconds(1);
    }
}
