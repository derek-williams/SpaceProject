using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour 
{
    public GameObject[] Asteroid;
    public Score score;

	void Start () 
	{
		// Destroy the rocket after 2 seconds if it doesn't get destroyed before then.
		Destroy(gameObject, 2);
        score = GameObject.Find("Score").GetComponent<Score>();
	}

	void OnTriggerEnter2D (Collider2D col) 
	{
		// If it hits an enemy...
		if(col.tag == "Enemy")
		{
			// Destroy the rocket.
            score.score = score.score + 150;
            score.previousScore = score.previousScore + 150;
            Destroy(col.gameObject);
			Destroy (gameObject);
		}

        if (col.tag == "BigRock")
        {
            Rock asteroid = new Rock();
            score.score = score.score + 100;
            score.previousScore = score.previousScore + 100;
            Destroy(gameObject);
            Instantiate(Asteroid[0], new Vector3(this.gameObject.transform.position.x * Random.Range(0, 10), this.gameObject.transform.position.y * Random.Range(0, 10), 0), Quaternion.identity);
            Instantiate(Asteroid[0], new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0), Quaternion.identity);
            Instantiate(Asteroid[0], new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0), Quaternion.identity);
            Destroy(col.gameObject);
        }

        if (col.tag == "MedRock")
        {
            Rock asteroid = new Rock();
            score.score = score.score + 50;
            score.previousScore = score.previousScore + 50;
            Destroy(gameObject);
            Instantiate(Asteroid[1], new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0), Quaternion.identity);
            Instantiate(Asteroid[1], new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0), Quaternion.identity);
            Destroy(col.gameObject);
            score.score += 50;
        }

        if (col.tag == "SmRock")
        {
            score.score = score.score + 25;
            score.previousScore = score.previousScore + 25;
            Rock asteroid = new Rock();
            Destroy(gameObject);
            Destroy(col.gameObject);
            score.score += 50;
        }

        // Otherwise if the player manages to shoot himself...
        else if(col.gameObject.tag != "Player")
        {
            Destroy (gameObject);
        }
	}
}
