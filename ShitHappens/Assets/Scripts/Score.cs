using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameObject scoreAdd;
    public GameObject canvas;
    public Transform scoreAddPos;

    Text scoreText;
    public string standardText;

    public int queScore;
    public int displayScore;

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
            queScore -= 10;
            timer = 0;  displayScore += 10;
          
            scoreText.text = standardText + displayScore.ToString();
        }
    }

    public void AddScore(int points)
    {
        queScore += (points * 2);

        /*GameObject obj = (GameObject)Instantiate(scoreAdd,scoreAddPos.localPosition, Quaternion.identity);
        obj.transform.SetParent(canvas.transform);
        obj.transform.localPosition = scoreAddPos.localPosition;
        obj.GetComponent<ScoreTextRemove>().worth = points;*/
    }
    IEnumerator addDelay()
    {
        yield return new WaitForSeconds(timerSpeed);
        canAdd = true;
    }
}
