using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    [SerializeField] float maxX;
    [SerializeField] float spawnInterval;

    [SerializeField] GameObject[] candies;

    public static CandySpawner instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        StartSpawningCandies();
    }

    void Update()
    {
        
    }

    void SpawnCandy()
    {
        int rand = Random.Range(0,candies.Length);
        float randX = Random.Range(-maxX, maxX);
        Vector3 randomPos = new Vector3(randX, transform.position.y, transform.position.z);
        Instantiate(candies[rand],randomPos,transform.rotation);
    }

    IEnumerator SpawnCandies()
    {
        yield return new WaitForSeconds(2f);
        while (true)
        {
            SpawnCandy();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    public void StartSpawningCandies()
    {
        StartCoroutine("SpawnCandies");
    }

    public void StopSpawningScandies()
    {
        StopCoroutine("SpawnCandies");
    }
}
