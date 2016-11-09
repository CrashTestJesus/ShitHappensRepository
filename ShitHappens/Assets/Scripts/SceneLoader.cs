using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public int sceneIndex;

    public GameObject musicHolder;

    void Update()
    {
        if (Input.GetButtonDown("Red"))
        {
            SceneManager.LoadScene(sceneIndex);
            //DontDestroyOnLoad(musicHolder);


        }
        //if (Application.loadedLevelName == "MenuScene")
        //{
        //    Destroy(musicHolder);
       // }
    }
}
