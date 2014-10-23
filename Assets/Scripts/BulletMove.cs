using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {

    float movex = 0;
    
    float delay = 0.5f;
    public GameObject bullet;

    void Start (){
        Invoke("Destroyer", delay);
    }

    void FixedUpdate ()
    {
        if (movex == 0) {
            movex = rigidbody2D.velocity.x + 20;
            if (movex != 0) {
                movex = 15*Mathf.Sign(movex);
                rigidbody2D.velocity += new Vector2(-movex, rigidbody2D.velocity.y);
            }
        } else 
            {
                rigidbody2D.velocity = new Vector2(-movex, rigidbody2D.velocity.y);
            }
    }
    void Destroyer()
    {
        Destroy(bullet);
    }
}
