using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerDeath : MonoBehaviour {

    GameManager manager;

    public Score finalScore;
    public GameObject particle;

    public BgMovement backgroundOne;
    public BgMovement backgroundTwo;

    public AudioClip Death;

    AudioSource Audio;

    public HumanSpawnChance humans;

    PlayerMovement mov;

    SpriteRenderer playerSprite;

    public string[] deathTags;

    void Start()
    {
        mov = GetComponent<PlayerMovement>();
        playerSprite = GetComponent<SpriteRenderer>();
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
   void OnTriggerEnter2D(Collider2D coll)
      {
        for (int i = 0; i < deathTags.Length; i++)
        {
            if (coll.gameObject.CompareTag(deathTags[i]))
            {
                death();
            }
        }
      }

    void death()
    {
        GetComponent<AudioSource>().PlayOneShot(Death, 1f);
        foreach (GameObject human in humans.humansOnScreen)
        {           

            int i = 0;
            i++;
            if(humans.humansOnScreen[i] != null)
            {
                human.GetComponent<HumanSpeeds>().movingSpeed = 0;
            }
            if(i == humans.humansOnScreen.Count)
            {
                Destroy(humans);
            }
        }
        humans.dead = true;
        mov.downSpeed = 0;
        mov.forwardSpeed = 0;
        mov.downSpeed = 0;
        backgroundOne.speed = 0;
        backgroundTwo.speed = 0;
        playerSprite.enabled = false;
        particle.SetActive(true);
        manager.playerScore = finalScore.displayScore;
        StartCoroutine(DeathDelay());
    }

    IEnumerator DeathDelay()
    {
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene(3);
    }
}
