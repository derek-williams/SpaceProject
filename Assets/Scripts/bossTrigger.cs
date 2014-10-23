using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class bossTrigger : MonoBehaviour {

    public GameObject hero;
    public GameObject bossCol;
    public List<GameObject> destObj;
    public GameObject boss;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == hero)
        {
            Invoke("BossBattle", 0.3f);

            foreach (GameObject obj in destObj)
            {
                Destroy(obj);
            }

            GameObject[] Enemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject enemy in Enemies)
            {
                Destroy(enemy);
            }
            GameObject[] Spawners = GameObject.FindGameObjectsWithTag("Spawner");
            foreach (GameObject spawner in Spawners)
            {
                Destroy(spawner);
            }
            GameObject[] BigRocks = GameObject.FindGameObjectsWithTag("BigRock");
            foreach (GameObject rockz in BigRocks)
            {
                Destroy(rockz);
            }
            GameObject[] MedRocks = GameObject.FindGameObjectsWithTag("MedRock");
            foreach (GameObject rockz in MedRocks)
            {
                Destroy(rockz);
            }
            GameObject[] SmRocks = GameObject.FindGameObjectsWithTag("SmRock");
            foreach (GameObject rockz in SmRocks)
            {
                Destroy(rockz);
            }

            boss.SetActive(true);

            Destroy(this.gameObject, 0.5f);
        }
    }
	
	// Update is called once per frame
	void BossBattle () {
        bossCol.SetActive(true);
	}
}
