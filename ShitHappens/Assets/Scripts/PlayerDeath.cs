using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerDeath : MonoBehaviour {

    GameManager manager;

    public Score finalScore;
    public GameObject particle;

    SpriteRenderer playerSprite;

    public string[] deathTags;

    void Start()
    {
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
