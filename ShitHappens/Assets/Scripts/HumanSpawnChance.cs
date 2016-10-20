using UnityEngine;
using System.Collections;

public class HumanSpawnChance : MonoBehaviour {

    public GameObject[] Humans;

    bool canSpawn = true;

	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
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
        yield return new WaitForSeconds(Random.Range(2, 3));
        canSpawn = true;
    }
}
