using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public int sceneIndex;

    public GameObject musicHolder;

    // Use this for initialization
    void Start () {

	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Red"))
        {
            SceneManager.LoadScene(sceneIndex);
            DontDestroyOnLoad(musicHolder);
        }
    }
}
