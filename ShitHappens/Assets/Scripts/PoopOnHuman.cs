using UnityEngine;
using System.Collections;

public class PoopOnHuman : MonoBehaviour {

    public Sprite normal;
    public Sprite pooped;

    public int pointsWorth;

    public Score scoreScript;

    SpriteRenderer SpriteRenderer;

	void Start ()
    {
        scoreScript = GameObject.Find("Score").GetComponent<Score>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Shit"))
        {
            SpriteRenderer.sprite = pooped;
            scoreScript.AddScore(pointsWorth);
        }
    }
}
