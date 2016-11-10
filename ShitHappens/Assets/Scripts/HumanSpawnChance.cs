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
            int RandomChance = Random.Range(0, 2001);

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
            if (rand == 3)
            {
                GameObject man = (GameObject)Instantiate(Humans[3], new Vector3(10f, -3.28f, 0f), Quaternion.identity);
                humansOnScreen.Add(man);
            }
            if (rand == 4)
            {
                GameObject buggy = (GameObject)Instantiate(Humans[4], new Vector3(10f, -3.28f, 0f), Quaternion.identity);
                humansOnScreen.Add(buggy);
            }
            if (rand == 5)
            {
                GameObject fisherMid = (GameObject)Instantiate(Humans[5], new Vector3(10f, -3.28f, 0f), Quaternion.identity);
                humansOnScreen.Add(fisherMid); 
            }
            if (rand == 6)
            {
                GameObject fatGuy = (GameObject)Instantiate(Humans[6], new Vector3(10f, -3.28f, 0f), Quaternion.identity);
                humansOnScreen.Add(fatGuy);
            }
            if (rand == 7)
            {
                GameObject couple = (GameObject)Instantiate(Humans[7], new Vector3(10f, -3.28f, 0f), Quaternion.identity);
                humansOnScreen.Add(couple);
            }
            if (RandomChance == 2000)
            {
                int chance = Random.Range(0, 2001);

                GameObject Rasta = (GameObject)Instantiate(Humans[8], new Vector3(10f, -3.28f, 0f), Quaternion.identity);
                humansOnScreen.Add(Rasta);
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