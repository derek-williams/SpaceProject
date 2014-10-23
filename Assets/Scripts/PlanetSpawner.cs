using UnityEngine;
using System.Collections;

public class PlanetSpawner : MonoBehaviour 
{
    public GameObject[] planets;
    public float totalNum;

    void Awake ()
    {
        for (int pCounter = 0; pCounter <= totalNum; ++pCounter)
        {
            SpawnRandomObject();
        }
    }

	void SpawnRandomObject() 
    {

    GameObject universe = Instantiate(planets[Random.Range(0,3)]) as GameObject;
    float x = Random.Range(300,631);
    float y = Random.Range(-5, 5);

    Vector2 newPosition = new Vector2(x, y);

    universe.transform.position = newPosition;
        
        
    }
}
