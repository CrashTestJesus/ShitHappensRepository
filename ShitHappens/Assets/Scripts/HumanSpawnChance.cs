using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HumanSpawnChance : MonoBehaviour {

    public GameObject[] Humans;

    bool canSpawn = true;

    public bool dead = false;

    public int minTime = 1;
    public int maxTime = 3;

    public List<GameObject> humansOnScreen = new List<GameObject>();

    void Update()
    {
        // Human spawner
        if (canSpawn == true)
        {
            int rand = Random.Range(0, Humans.Length);

            if (rand == 0)
            {
                GameObject human = (GameObject)Instantiate(Humans[0], new Vector3(10f, -1.86f, 0f), Quaternion.identity);
                humansOnScreen.Add(human);
            }

            if (rand == 1)
            {
                GameObject child1 = (GameObject)Instantiate(Humans[1], new Vector3(10f, -2.32f, 0f), Quaternion.identity);
                humansOnScreen.Add(child1);
            }

            if (rand == 2)
            {
                GameObject woman = (GameObject)Instantiate(Humans[2], new Vector3(10f, -1.86f, 0f), Quaternion.identity);
                humansOnScreen.Add(woman);
            }

            canSpawn = false;
            StartCoroutine(HumanSpawnDelay());
        }
    }

    IEnumerator HumanSpawnDelay()
    {
        yield return new WaitForSeconds(Random.Range(minTime, maxTime));
        if (!dead)
        {
            canSpawn = true;
        }       
    }
}