using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefreshDog : MonoBehaviour
{
    public GameObject Dog;
    public Vector3 spawnRange;
    public int maxConsumer; // should be maxDog
    public float spawnInterval;

    private int currentDog;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnDog());
    }

    IEnumerator SpawnDog()
    {
        while (true)
        {
            if (currentDog < maxConsumer)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnRange.x, spawnRange.x), 0, Random.Range(-spawnRange.z, spawnRange.z));
                GameObject newDog = Instantiate(Dog, spawnPosition, Quaternion.identity);
                newDog.tag = "dog"; // Set the tag to "dog"

                currentDog++;
            }

            yield return new WaitForSeconds(spawnInterval);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Check the number of current dogs in the scene
        currentDog = GameObject.FindGameObjectsWithTag("dog").Length;
    }
}
