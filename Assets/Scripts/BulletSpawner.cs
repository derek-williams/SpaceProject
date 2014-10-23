using UnityEngine;
using System.Collections;

public class BulletSpawner : MonoBehaviour {


    public float spawnTime = 5f;		// The amount of time between each spawn.
    public float spawnDelay = 3f;		// The amount of time before spawning starts.
    public GameObject[] bullets;		// Array of enemy prefabs. 
    private Vector3 bulletVec;


    void Start()
    {
        // Start calling the Spawn function repeatedly after a delay .
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }

    void Update() {
        if (this.transform.localScale.x < 0)
        {
            bulletVec = (this.transform.position + (-this.transform.right));
        }

        else {
            bulletVec = (this.transform.position + (-this.transform.right * 3.0f));
        }


        
    }
    void Spawn()
    {
        Instantiate(bullets[0], this.transform.position, this.transform.rotation);
    }
}
