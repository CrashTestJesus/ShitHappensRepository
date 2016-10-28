using UnityEngine;
using System.Collections;

public class HumanSpawnChance : MonoBehaviour {

    public GameObject[] Humans;

    bool canSpawn = true;

	void Start () {

    }

    void Update()
    {

        // Human spawner
        if (canSpawn == true)
        {
            Instantiate(Humans[Random.Range(0, Humans.Length)], new Vector3(10f, -2f, 0f), Quaternion.identity);
            canSpawn = false;
            StartCoroutine(HumanSpawnDelay());
        }
    }

    IEnumerator HumanSpawnDelay()
    {
        yield return new WaitForSeconds(Random.Range(1f, 3f));
        canSpawn = true;
    }
}
