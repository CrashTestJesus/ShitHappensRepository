using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Sprite playerSprite;

    public int playerScore;

    public string playerName;

    private static GameManager instance = null;

    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}
