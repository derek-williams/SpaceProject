using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {


    private SpriteRenderer ren;
    private Transform frontCheck;
    private bool amColliding;
    private int bossLife;
    private int counter;
    private int lungeCount;
    private int masterCount;
    private int colCounter;
    public AudioClip bossSound;

    private bool wormState;

    void Awake()
    {
        // Setting up the references.
        ren = transform.Find("body").GetComponent<SpriteRenderer>();
        frontCheck = transform.Find("frontCheck").transform;
    }

    void Update()
    {
        #region old boss
        /* counter++;
        
        if (counter >= 300) { counter = 0; }

        if ( counter < 50 )
        {
            this.gameObject.rigidbody2D.AddForce(Vector2.up * 30);
        }

        if ( counter > 100 )
        {
            this.gameObject.rigidbody2D.AddForce(-Vector2.up * 30);
        }

        if (lungeCount == 2 | lungeCount == 4 | lungeCount == 6 | lungeCount == 8 | lungeCount == 10)
        {
            if (counter > 50 && counter < 160)
            {
                this.gameObject.rigidbody2D.AddForce(-Vector2.right * 100);
                lungeCount++;
            }
            lungeCount = 0;
        }

        if (lungeCount <= 10)
        {
            if (counter >= 150)
            {
                this.gameObject.rigidbody2D.AddForce(Vector2.right * 100);
            }
            if (counter < 150)
            {
                this.gameObject.rigidbody2D.AddForce(-Vector2.right * 100);
                lungeCount++;
            }
        }

        if (lungeCount == 10)
        {
            lungeCount = 0;
        }

        if (lungeCount < 6)
        {
            if (counter >= 150)
            {
                this.gameObject.rigidbody2D.AddForce(-Vector2.right * 100);
                lungeCount++;
            }
            if (counter > 150)
            {
                this.gameObject.rigidbody2D.AddForce(Vector2.right * 100);
            }
        }*/
        #endregion

        #region newboss
        counter++;
        if (counter > 0 && counter < 40)
        {
            this.gameObject.rigidbody2D.AddForce(-Vector2.up * 30);
        }

        if (counter > 40)
        {
            this.gameObject.rigidbody2D.AddForce(Vector2.up * 30);
        }
        if (counter == 90) 
        {
            counter = 0;
            AudioSource.PlayClipAtPoint(bossSound, this.transform.position, 1);
        }
        #endregion
    }

	// Use this for initialization
	void Start ()
    {
        amColliding = false;
        counter = 0;
        masterCount = 0;
        lungeCount = 0;
        wormState = false;
	}

    void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.tag == "Bullet")
        {
            colCounter++;
        }

        if (colCounter == 150)
        {
            Destroy (this.gameObject);
            Application.LoadLevel("EndCutScene");
        }
    }

}
