using UnityEngine;
using System.Collections;

public class SceneLoaderScore : MonoBehaviour {

    int sceneIndex2 = 4;

    public GameObject musicholder;
	
	// Update is called once per frame
	void Update () {
        if (sceneIndex2 == 4)
        {

            if (Input.GetButtonDown("Red"))
            {
               
                Application.LoadLevel("HighScoreScene");
                DontDestroyOnLoad(musicholder);

            }
        }

        if (Application.loadedLevelName == "StartScene")
        {
            Destroy(musicholder);
        }
    }
}
