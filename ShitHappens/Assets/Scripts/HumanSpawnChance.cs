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
            GameObject human = (GameObject) Instantiate(Humans[Random.Range(0, Humans.Length)], new Vector3(10f, -1.86f, 0f), Quaternion.identity);
            humansOnScreen.Add(human);
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