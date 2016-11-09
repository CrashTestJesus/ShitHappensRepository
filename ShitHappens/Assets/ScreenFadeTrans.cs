using UnityEngine;
using UnityEngine.UI;

public class ScreenFadeTrans : MonoBehaviour {

    Color c;
    public Color startColor;
    public float speed;
    Image img;

    void Start()
    {
        img = GetComponent<Image>();
        c = img.material.color;
        c = startColor;
    }

    void Update()
    {
        c.a -= speed * Time.deltaTime;
        img.material.color = c;
        Destroy(gameObject, 1);
    }
}
