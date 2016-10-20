using UnityEngine;
using System.Collections;

public class MenuNav : MonoBehaviour {

    public float delay;

    int index = 1;

    bool canMove = true;
    bool bottomRow;
	
	void Update () {
        float xMove = Input.GetAxis("Horizontal");
        float yMove = Input.GetAxis("Vertical"); 

        if(xMove > 0 && canMove && index >= 1 && index <= 2)
        {
            canMove = false;
            index++;
            StartCoroutine(SelectDelay());
        }
        if (xMove < 0 && canMove && index >= 2 && index <= 3)
        {
            canMove = false;
            index--;
            StartCoroutine(SelectDelay());
        }

    }
    IEnumerator SelectDelay()
    {
        yield return new WaitForSeconds(delay);

        canMove = true;
    }
}
