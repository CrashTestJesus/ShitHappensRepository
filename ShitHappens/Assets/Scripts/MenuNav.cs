using UnityEngine;
using System.Collections;

public class MenuNav : MonoBehaviour {

    public float delay;

    int index = 1;

    bool canMove = true;
    bool bottomRow;

    RectTransform trans;
	
    void Start()
    {
        trans = GetComponent<RectTransform>();
    }

	void Update () {
        float xMove = Input.GetAxis("Horizontal");
        float yMove = Input.GetAxis("Vertical"); 
        
        if(xMove > 0 && canMove && index >= 1 && index <= 2 && !bottomRow)
        {
            trans.localPosition += new Vector3(116, 0, 0);
            canMove = false;
            index++;
            StartCoroutine(SelectDelay());
        }
        if (xMove < 0 && canMove && index >= 2 && index <= 3 && !bottomRow)
        {
            trans.localPosition -= new Vector3(116, 0, 0);
            canMove = false;
            index--;
            StartCoroutine(SelectDelay());
        }

        if (xMove > 0 && canMove && index >= 101 && index <= 102 && bottomRow)
        {
            trans.localPosition += new Vector3(116, 0, 0);
            canMove = false;
            index++;
            StartCoroutine(SelectDelay());
        }
        if (xMove < 0 && canMove && index >= 102 && index <= 103 && bottomRow)
        {
            trans.localPosition -= new Vector3(116, 0, 0);
            canMove = false;
            index--;
            StartCoroutine(SelectDelay());
        }

        if (yMove > 0 && canMove && bottomRow)
        {
            bottomRow = false;
            trans.localPosition += new Vector3(0, 104, 0);
            canMove = false;
            StartCoroutine(SelectDelay());
            index -= 100;
        }
        if(yMove < 0 && canMove && !bottomRow)
        {
            bottomRow = true;
            trans.localPosition -= new Vector3(0, 104, 0);
            canMove = false;
            StartCoroutine(SelectDelay());
            index += 100;
        }
    }
    IEnumerator SelectDelay()
    {
        yield return new WaitForSeconds(delay);

        canMove = true;
    }
}
