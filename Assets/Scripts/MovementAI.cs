using UnityEngine;
using System.Collections;

public class MovementAI : MonoBehaviour
{
    public bool facingRight = true;
    private GameObject player;
    public float movementSpeed = 2f;
    public float moveForce = 1f;			// Amount of force added to move the player left and right.
    public float maxSpeed = 5f;				// The fastest the player can travel in the x axis.
    public float lockRot = 0f;
    // Use this for initialization

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float step = movementSpeed * Time.deltaTime;
        this.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, player.transform.position, step);
    }
}