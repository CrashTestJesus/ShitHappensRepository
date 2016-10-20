using UnityEngine;
using System.Collections;

public class MusicLoader : MonoBehaviour {

    public AudioClip Selection;

    AudioSource Sound;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey(KeyCode.R))
        {
            GetComponent<AudioSource>().PlayOneShot(Selection, 1f);
        }
    }
}
