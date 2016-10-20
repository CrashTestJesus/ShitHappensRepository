using UnityEngine;
using System.Collections;

public class SceneLoader : MonoBehaviour {

    public GameObject MusicHolder;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel("MenuScene");
            DontDestroyOnLoad(MusicHolder);
        }
	}
}
