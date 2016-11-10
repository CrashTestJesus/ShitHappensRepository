using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public int sceneIndex;

    public GameObject musicHolder;

    void Update()
    {
        if (sceneIndex < 1)
        {
            if (Input.GetButtonDown("Red"))
            {
                sceneIndex += 1;
                SceneManager.LoadScene(sceneIndex);
                DontDestroyOnLoad(musicHolder);
                print(sceneIndex);
            }
        }
        if (Application.loadedLevelName == "GameScene")
        {
            Destroy(musicHolder);
        }
    }
}
