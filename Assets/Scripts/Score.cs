using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
    private Lives lives;
	public int score = 0;					// The player's score.


	private PlayerControl playerControl;	// Reference to the player control script.
	public int previousScore;			// The score in the previous frame.


	void Awake ()
	{
		// Setting up the reference.
		playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
	}


	void Update ()
	{
		// Set the score text.
		guiText.text = "Score: " + score;
        previousScore = score;

	}

}
