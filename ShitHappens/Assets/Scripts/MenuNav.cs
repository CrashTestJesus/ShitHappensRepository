using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public enum species{hat, pirate, emo, fairy, girl, princess }
public class MenuNav : MonoBehaviour {
    GameManager manager;

    public int sceneIndex;

    public float delay;

    int index = 1;

    bool canMove = true;
    bool bottomRow;

    RectTransform trans;

    public AudioClip Selection;
    public AudioClip start;

    AudioSource Sound;

    public Sprite[] sprites;

    public GameObject musicHolder;

    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        trans = GetComponent<RectTransform>();
    }

	void Update () {
        //submitPlayer
        if (Input.GetButtonDown("Red"))
        {
            GetComponent<AudioSource>().PlayOneShot(start, 1f);
            switch (index)
            {
                case 1:
                    manager.playerSprite = sprites[0];
                    manager.kind = species.hat;
                    break;
                case 2:
                    manager.playerSprite = sprites[1];
                    manager.kind = species.pirate;
                    break;
                case 3:
                    manager.playerSprite = sprites[2];
                    manager.kind = species.emo;
                    break;
                case 101:
                    manager.playerSprite = sprites[3];
                    manager.kind = species.fairy;
                    break;
                case 102:
                    manager.playerSprite = sprites[4];
                    manager.kind = species.girl;
                    break;
                case 103:
                    manager.playerSprite = sprites[5];
                    manager.kind = species.princess;
                    break;
            }
            SceneManager.LoadScene(sceneIndex);
        }
        //select player
        float xMove = Input.GetAxis("Horizontal");
        float yMove = Input.GetAxis("Vertical"); 
        
        if(xMove > 0 && canMove && index >= 1 && index <= 2 && !bottomRow)
        {
            GetComponent<AudioSource>().PlayOneShot(Selection, 1f);
            trans.localPosition += new Vector3(116, 0, 0);
            canMove = false;
            index++;
            StartCoroutine(SelectDelay());
        }
        if (xMove < 0 && canMove && index >= 2 && index <= 3 && !bottomRow)
        {
            GetComponent<AudioSource>().PlayOneShot(Selection, 1f);
            trans.localPosition -= new Vector3(116, 0, 0);
            canMove = false;
            index--;
            StartCoroutine(SelectDelay());
        }

        if (xMove > 0 && canMove && index >= 101 && index <= 102 && bottomRow)
        {
            GetComponent<AudioSource>().PlayOneShot(Selection, 1f);
            trans.localPosition += new Vector3(116, 0, 0);
            canMove = false;
            index++;
            StartCoroutine(SelectDelay());
        }

        if (xMove < 0 && canMove && index >= 102 && index <= 103 && bottomRow)
        {
            GetComponent<AudioSource>().PlayOneShot(Selection, 1f);
            trans.localPosition -= new Vector3(116, 0, 0);
            canMove = false;
            index--;
            StartCoroutine(SelectDelay());
        }

        if (yMove > 0 && canMove && bottomRow)
        {
            GetComponent<AudioSource>().PlayOneShot(Selection, 1f);
            bottomRow = false;
            trans.localPosition += new Vector3(0, 104, 0);
            canMove = false;
            StartCoroutine(SelectDelay());
            index -= 100;
        }
        if(yMove < 0 && canMove && !bottomRow)
        {
            GetComponent<AudioSource>().PlayOneShot(Selection, 1f);
            bottomRow = true;
            trans.localPosition -= new Vector3(0, 104, 0);
            canMove = false;
            StartCoroutine(SelectDelay());
            index += 100;
        }
    }
    IEnumerator SelectDelay()
    {
        yield return new WaitForSeconds(delay);

        canMove = true;
    }
}
