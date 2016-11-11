using UnityEngine;
using System.Collections;

public class PoopOnHuman : MonoBehaviour {

    public Sprite pooped;
    public Sprite foodGone;

    public Animator anim;

    public AudioClip Hit;

    AudioSource sound;

    public int pointsWorth;

    public bool runnerShatOn = false;
    public bool shatOn = false;

    public Score scoreScript;

    SpriteRenderer SpriteRenderer;

	void Start ()
    {
        anim = GetComponent<Animator>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        scoreScript = GameObject.Find("Score").GetComponent<Score>();

        GameObject girl1 = GameObject.Find("girl1");
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Shit"))
        {
            GetComponent<AudioSource>().PlayOneShot(Hit, 1f);
            anim.SetBool("pooped", true);
            Destroy(anim);
            SpriteRenderer.sprite = pooped;
            scoreScript.AddScore(pointsWorth);
            runnerShatOn = true;
            shatOn = true;
        }
        if (other.gameObject.CompareTag("Food"))
            
            {
            GetComponent<AudioSource>().PlayOneShot(Hit, 1f);
            anim.SetBool("Food", true);
            Destroy(anim);
            SpriteRenderer.sprite = foodGone;
        }
    }
}
