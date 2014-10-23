using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour
{					
    private Score score;
    public int lives;


    private PlayerControl playerControl;	// Reference to the player control script.
    private int previousLives = 0;			// The score in the previous frame.


    void Awake()
    {
        // Setting up the reference.
        playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
        score = GameObject.Find("Score").GetComponent<Score>();
        lives += 3;
    }


    void FixedUpdate()
    {
        int i = score.previousScore;

        if (i == 3000)
        {
            lives = lives + 1;
            score.previousScore = 0;
        }

        if (i == 6000)
        {
            lives = lives + 1;
            score.previousScore = 0;
        }

        if (i == 9000)
        {
            lives = lives + 1;
            score.previousScore = 0;
        }

        if (i == 12000)
        {
            lives = lives + 1;
            score.previousScore = 0;
        }

        guiText.text = "Lives: " + lives;

    }
}