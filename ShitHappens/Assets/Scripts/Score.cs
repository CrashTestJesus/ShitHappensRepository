using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreText;
    public string standardText;

    public int queScore;
    int displayScore;

    public float timerSpeed;
    float timer;

    bool canAdd = true;
	void Start () {
        scoreText = GetComponent<Text>();
        scoreText.text = standardText;
	}
    void Update()
    {
        timer += Time.time;
        if(queScore != displayScore && canAdd)
        {
            canAdd = false;
            StartCoroutine(addDelay());
            displayScore += 10;
            queScore -= 10;
            timer = 0;
            scoreText.text = standardText + displayScore.ToString();
        }
    }

    public void AddScore(int points)
    {
        queScore += (points * 2);
    }
    IEnumerator addDelay()
    {
        yield return new WaitForSeconds(timerSpeed);
        canAdd = true;
    }
}
