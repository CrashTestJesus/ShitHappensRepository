using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HumanSpawnChance : MonoBehaviour {

    public GameObject[] Humans;
    public GameObject[] Stands;

    bool canSpawn = true;
    bool canSpawn2 = true;

    public bool dead = false;

    public int minTime = 2;
    public int maxTime = 3;
    public int maxTime2 = 10;

    public List<GameObject> humansOnScreen = new List<GameObject>();
    public List<GameObject> standsOnScreen = new List<GameObject>();

    void Update()
    {
        // stand spawner
        if (canSpawn2 == true)
        {
            int stand = Random.Range(0, Stands.Length);

            if (stand == 0)
            {
                GameObject fries = (GameObject)Instantiate(Stands[0], new Vector3(15f, -3.4f, 0f), Quaternion.identity);
                standsOnScreen.Add(fries);
            }
            if (stand == 1)
            {
                GameObject ice = (GameObject)Instantiate(Stands[1], new Vector3(15f, -3.4f, 0f), Quaternion.identity);
                standsOnScreen.Add(ice);
            }
            if (stand == 2)
            {
                GameObject hotdog = (GameObject)Instantiate(Stands[2], new Vector3(15f, -3.4f, 0f), Quaternion.identity);
                standsOnScreen.Add(hotdog);
            }

            canSpawn2 = false;
            StartCoroutine(StandSpawnDelay());
        }
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
            if (rand == 9)
            {
                GameObject child2 = (GameObject)Instantiate(Humans[9], new Vector3(10f, -2.32f, 0f), Quaternion.identity);
                humansOnScreen.Add(child2);
            }
            if (rand == 10)
            {
                GameObject child3 = (GameObject)Instantiate(Humans[10], new Vector3(10f, -2.32f, 0f), Quaternion.identity);
                humansOnScreen.Add(child3);
            }
            if (rand == 11)
            {
                GameObject woman1 = (GameObject)Instantiate(Humans[11], new Vector3(10f, -1.92f, 0f), Quaternion.identity);
                humansOnScreen.Add(woman1);
            }
            if (rand == 12)
            {
                GameObject woman2 = (GameObject)Instantiate(Humans[12], new Vector3(10f, -3.31f, 0f), Quaternion.identity);
                humansOnScreen.Add(woman2);
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

    IEnumerator StandSpawnDelay()
    {
        yield return new WaitForSeconds(Random.Range(minTime, maxTime2));
        if (!dead)
        {
            canSpawn2 = true;
        }
    }
}