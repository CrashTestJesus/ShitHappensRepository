using UnityEngine;
using System.Collections;

public class PoopOnHuman : MonoBehaviour {

    public Sprite pooped;

    Animator anim;

    public AudioClip Hit;

    AudioSource sound;

    public int pointsWorth;

    public Score scoreScript;

    SpriteRenderer SpriteRenderer;

	void Start ()
    {
        anim = GetComponent<Animator>();
        scoreScript = GameObject.Find("Score").GetComponent<Score>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Shit"))
        {
            GetComponent<AudioSource>().PlayOneShot(Hit, 1f);
            anim.SetBool("pooped", true);
            SpriteRenderer.sprite = pooped;
            scoreScript.AddScore(pointsWorth);
        }
    }
}
