using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float downSpeed;
    public float upSpeed;
    public float forwardSpeed;

    public float delay;

    public Sprite[] sprites;
    public Sprite failSafe;

    bool CanMove = true;

    SpriteRenderer spriteRen;

    Animator anim;

    GameManager manager;

    void Start()
    {
        anim = GetComponent<Animator>();
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        spriteRen = GetComponent<SpriteRenderer>();
        sprites[0] = manager.playerSprite;
        if (sprites[0] != null)
        {
            spriteRen.sprite = sprites[0];
        }
        else
        {
            spriteRen.sprite = failSafe;
        }
        switch (manager.kind)
        {
            case species.hat:
                anim.SetBool("hat", true);
                break;
            case species.pirate:
                anim.SetBool("hat", true);
                break;
            case species.emo:
                anim.SetBool("hat", true);
                break;
            case species.fairy:
                anim.SetBool("hat", true);
                break;
            case species.girl:
                anim.SetBool("hat", true);
                break;
            case species.princess:
                anim.SetBool("hat", true);
                break;
        }
    }

    void Update()
    {
        if (CanMove == true)
        {
            float yAxis = Mathf.Clamp(Input.GetAxis("Vertical"), -1, 0);
            float xAxis = Input.GetAxis("Horizontal");


            transform.position += new Vector3(xAxis * forwardSpeed, yAxis * downSpeed, 0) * Time.deltaTime;

            if (yAxis >= 0 && transform.position.y < 2.5f)
            {
                StartCoroutine(DiveDelay());
                transform.position = Vector3.Lerp(transform.position, transform.position += new Vector3(0, upSpeed, 0), Time.deltaTime);
            }
        }
    }

    void OnColliderEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("DestroyShit"))
        {
            print("hit");
            //CanMove = false;
            //transform.Translate(Vector2.down);
        }
    }

    IEnumerator DiveDelay()
    {
        yield return new WaitForSeconds(delay);
        //divesprite
        //spriteRen.sprite = sprites[0];
    }
}
