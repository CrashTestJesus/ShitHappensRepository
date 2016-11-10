using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class NameScript : MonoBehaviour {

    public float delay;

    string letterOne;
    string letterTwo;
    string letterThree;

    public Text firstLetter;
    public Text secondLetter;
    public Text thirdLetter;

    public int score;

    int letterIndex;

    int alphabetIndexOne;
    int alphabetIndexTwo;
    int alphabetIndexThree;

    bool canChange = true;

    public GameObject arrows;

    public int xPosFirst;
    public int xPosSecond;
    public int xPosThird;

    public AudioClip ding;

    AudioSource source;

    public string[] alphabet = new string[26];

    public GameManager manager;

	void Start () {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();

            letterIndex = 1;

            alphabetIndexOne = 0;
            alphabetIndexTwo = 0;
            alphabetIndexThree = 0;

            letterOne = "A";
            letterTwo = "A";
            letterThree = "A";

            arrows.GetComponent<RectTransform>().localPosition = new Vector3(xPosFirst, 0, 0);
    }
	
	void Update () {

        float axisY = Input.GetAxisRaw("Vertical");
        float axisX = Input.GetAxisRaw("Horizontal");

        switch (letterIndex)
        {
            case 1:
                arrows.GetComponent<RectTransform>().localPosition = new Vector3(xPosFirst, 0, 0);
                break;
            case 2:
                arrows.GetComponent<RectTransform>().localPosition = new Vector3(xPosSecond, 0, 0);
                break;
            case 3:
                arrows.GetComponent<RectTransform>().localPosition = new Vector3(xPosThird, 0, 0);
                break;
        }
        if(axisY > 0 && canChange)
        {

            //hierzo
            GetComponent<AudioSource>().PlayOneShot(ding, 1f);
            switch (letterIndex)
            {
                case 1:
                    if (alphabetIndexOne <= alphabet.Length)
                    {
                        alphabetIndexOne++;
                        letterOne = alphabet[alphabetIndexOne];
                        firstLetter.text = alphabet[alphabetIndexOne];
                    }
                    else
                    {
                        alphabetIndexOne = 0;
                        letterOne = alphabet[alphabetIndexOne];
                        firstLetter.text = alphabet[alphabetIndexOne];
                    }
                    break;
                case 2:
                    if (alphabetIndexTwo <= alphabet.Length)
                    {
                        alphabetIndexTwo++;
                        letterTwo = alphabet[alphabetIndexTwo];
                        secondLetter.text = alphabet[alphabetIndexTwo];
                    }
                    else
                    {
                        alphabetIndexTwo = 0;
                        letterTwo = alphabet[alphabetIndexTwo];
                        secondLetter.text = alphabet[alphabetIndexTwo];
                    }
                    break;
                case 3:
                    if (alphabetIndexThree <= alphabet.Length)
                    {
                        alphabetIndexThree++;
                        letterThree = alphabet[alphabetIndexThree];
                        thirdLetter.text = alphabet[alphabetIndexThree];
                    }
                    else
                    {
                        alphabetIndexThree = 0;
                        letterThree = alphabet[alphabetIndexThree];
                        thirdLetter.text = alphabet[alphabetIndexThree];
                    }
                    break;

            }
            canChange = false;
            StartCoroutine(Delay());
        }
        if (axisY < 0 && canChange)
        {
            switch (letterIndex)
            {
                case 1:
                    if (alphabetIndexOne > 0)
                    {
                        alphabetIndexOne--;
                        letterOne = alphabet[alphabetIndexOne];
                        firstLetter.text = alphabet[alphabetIndexOne];
                    }
                    else
                    {
                        alphabetIndexOne = 25;
                        letterOne = alphabet[alphabetIndexOne];
                        firstLetter.text = alphabet[alphabetIndexOne];
                    }
                    break;
                case 2:
                    if (alphabetIndexTwo > 0)
                    {
                        alphabetIndexTwo--;
                        letterTwo = alphabet[alphabetIndexTwo];
                        secondLetter.text = alphabet[alphabetIndexTwo];
                    }
                    else
                    {
                        alphabetIndexTwo = 25;
                        letterTwo = alphabet[alphabetIndexTwo];
                        secondLetter.text = alphabet[alphabetIndexTwo];
                    }
                    break;
                case 3:
                    if (alphabetIndexThree > 0)
                    {
                        alphabetIndexThree--;
                        letterThree = alphabet[alphabetIndexThree];
                        thirdLetter.text = alphabet[alphabetIndexThree];
                    }
                    else
                    {
                        alphabetIndexThree = 25;
                        letterThree = alphabet[alphabetIndexThree];
                        thirdLetter.text = alphabet[alphabetIndexThree];
                    }
                    break;

            }
            canChange = false;
            StartCoroutine(Delay());
        }
        if (axisX > 0 && canChange)
        {
            if(letterIndex < 3)
            {
                letterIndex++;
                canChange = false;
                StartCoroutine(Delay());
            }
        }
        if(axisX < 0 && canChange)
        {
            if(letterIndex > 1)
            {
                letterIndex--;
                canChange = false;
                StartCoroutine(Delay());
            }
        }
        if (Input.GetButtonDown("Red") && canChange)
        {
            Submit();
        }
	}

    void Submit()
    {
        GetComponent<AudioSource>().PlayOneShot(ding, 1f);
        string fullName = letterOne + letterTwo + letterThree;
        manager.playerName = fullName;
        SceneManager.LoadScene(4);
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(delay);
        canChange = true;
    }
}