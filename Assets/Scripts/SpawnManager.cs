using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float xRange = 10;
    private float yRange = 10;

    public float delay;
    public GameObject[] wolves;
    public GameObject wisp;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
       
        
        InvokeRepeating("SpawnRandomWolf", delay, gameManager.interval);
        InvokeRepeating("SpawnRandomWisp", delay * 2, gameManager.interval * 2);
        
            
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    Vector2 RandomSpawnPos() 
    {
        float randomX= Random.Range(0 - xRange, 0  + xRange);
        float randomY= Random.Range(0 - yRange, 0 + yRange);

        return new Vector2(randomX, randomY); 
    }

    private void SpawnRandomWolf() 
    {
        int wolfIndex = Random.Range(0, wolves.Length);
        Instantiate(wolves[wolfIndex],  RandomSpawnPos(), Quaternion.identity);
    }

    private void SpawnRandomWisp() { Instantiate(wisp, RandomSpawnPos(), Quaternion.identity); }
}
