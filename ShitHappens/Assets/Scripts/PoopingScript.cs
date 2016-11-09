using UnityEngine;
using UnityEngine.UI;

public class PoopingScript : MonoBehaviour {

    public GameObject bullet;
    public GameObject poop;

    public Transform pigeon;

    public AudioClip Fart;
    public AudioClip Ammo;

    AudioSource Sound;

    public Image[] ammo;

    public int ammunition = 5;

    bool canShit = true;

	void Update () {
        if (canShit == true)
        {
            if (Input.GetButtonDown("Red"))
            {
                GetComponent<AudioSource>().PlayOneShot(Fart, 1f);
                poop = (GameObject)Instantiate(bullet, pigeon.position, transform.rotation);
                Pooping();
            }
        }
        if (ammunition == 0)
        {
            canShit = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            Eating();
        }
    }

    void Pooping()
    {
        ammunition--;

        ammo[ammunition].enabled = false;
/*
        switch (ammunition)
        {
            case 0:
                ammo[0].enabled = false;
                break;
            case 1:
                ammo[1].enabled = false;
                break;
            case 2:
                ammo[2].enabled = false;
                break;
            case 3:
                ammo[3].enabled = false;
                break;
            case 4:
                ammo[4].enabled = false;
                break;
        }
        */
    }

    void Eating()
    {
        GetComponent<AudioSource>().PlayOneShot(Ammo, 1f);
        canShit = true;
        ammunition++;

        switch (ammunition-1)
        {
            case 0:
                ammo[0].enabled = true;
                break;
            case 1:
                ammo[1].enabled = true;
                break;
            case 2:
                ammo[2].enabled = true;
                break;
            case 3:
                ammo[3].enabled = true;
                break;
            case 4:
                ammo[4].enabled = true;
                break;
        }

        if (ammunition > 5)
        {
            ammunition--;
        }
    }
}
