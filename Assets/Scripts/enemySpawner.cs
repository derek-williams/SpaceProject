using UnityEngine;
using System.Collections;

public class enemySpawner : MonoBehaviour
{
    public GameObject[] enemies;
    public float totalNum;

    void Awake()
    {
        for (int pCounter = 0; pCounter <= totalNum; ++pCounter)
        {
            SpawnRandomObject();
        }
    }

    void SpawnRandomObject()
    {

        GameObject enemyCollection = Instantiate(enemies[0]) as GameObject;
        float x = Random.Range(0, 310);
        float y = Random.Range(-4, 4);

        Vector2 newPosition = new Vector2(x, y);

        enemyCollection.transform.position = newPosition;


    }
}