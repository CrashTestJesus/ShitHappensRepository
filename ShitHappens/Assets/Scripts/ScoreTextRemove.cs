using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreTextRemove : MonoBehaviour {

    Text t;
    Color c;
    public Color startColor;
    public float speed;
    public int worth;

	void Start () {
        t = GetComponent<Text>();
        c = t.material.color;
        c = startColor;
        t.text = "+" + worth.ToString();
	}
	
	void Update () {
        c.a -= speed * Time.deltaTime;
        t.material.color = c;     
        Destroy(gameObject, 1);        
	}
}
