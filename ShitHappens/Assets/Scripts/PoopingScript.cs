using UnityEngine;
using UnityEngine.UI;

public class PoopingScript : MonoBehaviour {

    public GameObject bullet;
    public GameObject poop;

    public Transform pigeon;

    public Image[] ammo;

    public int ammunition = 5;

    bool canShit = true;

	void Update () {
        if (canShit == true)
        {
            if (Input.GetButtonDown("Red"))
            {
                poop = (GameObject)Instantiate(bullet, transform.position, transform.rotation);
                poop.transform.position = new Vector3(pigeon.position.x, 1.5f, 0f);
                Pooping();
            }
        }
        if (ammunition == 0)
        {
            canShit = false;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            Eating();
        }
    }

    void Pooping()
    {
        ammunition--;

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
    }

    void Eating()
    {
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
