using UnityEngine;
using System.Collections;

public class MusicLoader : MonoBehaviour {

    public AudioClip Selection;

    AudioSource Sound;

    void Start () {
	
	}
	
	void Update () {
	if (Input.GetKey(KeyCode.R))
        {
            GetComponent<AudioSource>().PlayOneShot(Selection, 1f);
        }
    }
}
