using UnityEngine;
using System.Collections;

public class Rock : MonoBehaviour {

	// References
	public GameObject childRockPrefab; 	// Reference to the child prefab this rock will produce when destroyed
	public AudioClip hitSfx;
    public GameObject Asteroid;
    public GameObject bullet;
    private GameObject hero;
    public Lives lives;

	//Properties
	public int numChildRocks = 1; 		// Number of children rocks this rock will produce when destroyed
	public float speed = 1f; 			// Speed of the rock
	private AudioSource audioSource; 	// Reference to the ships audio source

	// Use this for initialization
	void Start () {
		audioSource = this.GetComponent<AudioSource>();
		transform.Rotate(Vector3.forward * Random.Range(0f, 360f));
        lives = GameObject.Find("Lives").GetComponent<Lives>();
        hero = GameObject.FindGameObjectWithTag("Player");

	}
	
	// Update is called once per frame
   void Update () {
       rigidbody2D.AddForce(transform.up * Random.value);
       rigidbody2D.AddForce(-transform.right * Random.value);
   }

    void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.gameObject.tag == "Player")
        {
                Destroy(Asteroid);
                --lives.lives;
                
                if (lives.lives <= 0)
                {
                    hero.SetActive(false);
                }
        }
    }
}
	
