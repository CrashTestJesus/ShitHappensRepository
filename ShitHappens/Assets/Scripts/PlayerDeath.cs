using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerDeath : MonoBehaviour {

    GameManager manager;

    public Score finalScore;
    public GameObject particle;

    public BackgroundController backgroundOneFront;
    public BackgroundController backgroundOneBack;
    public BackgroundController backgroundOneMid;
    public BackgroundController backgroundTwoFront;
    public BackgroundController backgroundTwoMid;
    public BackgroundController backgroundTwoBack;

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
            if (i == humans.humansOnScreen.Count)
            {
                Destroy(humans);
            }
        }
        foreach (GameObject stand in humans.standsOnScreen)
        {
            int i = 0;
            
            if (humans.standsOnScreen[i] != null)
            {
                stand.GetComponent<StandSpeed>().StandsSpeed = 0;
            }
            i++;
            if (i == humans.standsOnScreen.Count)
            {
                Destroy(humans);
            }
        }
        humans.dead = true;
        mov.downSpeed = 0;
        mov.forwardSpeed = 0;
        mov.downSpeed = 0;
        backgroundOneFront.speed = 0;
        backgroundOneBack.speed = 0;
        backgroundOneMid.speed = 0;
        backgroundTwoFront.speed = 0;
        backgroundTwoMid.speed = 0;
        backgroundTwoBack.speed = 0;
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
