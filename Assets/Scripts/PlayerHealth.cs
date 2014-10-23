    using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100f;					// The player's health.
    public float repeatDamagePeriod = 2f;		// How frequently the player can be damaged.
    public AudioSource ouchClip;				// Array of clips to play when the player is damaged.
    public float hurtForce = 10f;				// The force with which the player is pushed when hurt.
    public float damageAmount = 10f;			// The amount of damage to take when enemies touch the player

    private SpriteRenderer healthBar;			// Reference to the sprite renderer of the health bar.
    private float lastHitTime;					// The time at which the player was last hit.
    private Vector3 healthScale;				// The local scale of the health bar initially (with full health).
    private PlayerControl playerControl;		// Reference to the PlayerControl script.
    private Animator anim;						// Reference to the Animator on the player
    public Lives lives;


    void Awake()
    {
        // Setting up references.
        playerControl = GetComponent<PlayerControl>();
        anim = GetComponent<Animator>();
        lives = GameObject.Find("Lives").GetComponent<Lives>();
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        // If the colliding gameobject is an Enemy...
        if (col.gameObject.tag == "Enemy")
        {
            --lives.lives;

            if (lives.lives == 0)
            {
                Collider2D[] cols = GetComponents<Collider2D>();
                foreach (Collider2D c in cols)
                {
                    c.isTrigger = true;
                }

                // Move all sprite parts of the player to the front
                SpriteRenderer[] spr = GetComponentsInChildren<SpriteRenderer>();
                foreach (SpriteRenderer s in spr)
                {
                    s.sortingLayerName = "UI";
                }

                anim.SetTrigger("Die");
                GetComponentInChildren<Gun>().enabled = false;
                GetComponent<PlayerControl>().enabled = false;
                this.gameObject.SetActive(false);
            }
        }

        if (col.gameObject.tag == "Boss")
        {
            --lives.lives;

            if (lives.lives == 0)
            {
                Collider2D[] cols = GetComponents<Collider2D>();
                foreach (Collider2D c in cols)
                {
                    c.isTrigger = true;
                }

                // Move all sprite parts of the player to the front
                SpriteRenderer[] spr = GetComponentsInChildren<SpriteRenderer>();
                foreach (SpriteRenderer s in spr)
                {
                    s.sortingLayerName = "UI";
                }

                anim.SetTrigger("Die");
                GetComponentInChildren<Gun>().enabled = false;
                GetComponent<PlayerControl>().enabled = false;
                this.gameObject.SetActive(false);
            }
        }

        if (col.gameObject.tag == "BigRock")
        {
            --lives.lives;

            if (lives.lives == 0)
            {
                this.gameObject.SetActive(false);
            }
        }
        if (col.gameObject.tag == "MedRock")
        {
            --lives.lives;

            if (lives.lives == 0)
            {
                this.gameObject.SetActive(false);
            }
        }
        if (col.gameObject.tag == "SmRock")
        {
            --lives.lives;

            if (lives.lives == 0)
            {
                this.gameObject.SetActive(false);
            }
        }
        if (lives.lives == 0)
        { ouchClip.Play(); }
    }
}
