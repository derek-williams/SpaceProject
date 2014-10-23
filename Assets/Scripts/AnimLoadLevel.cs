using UnityEngine;
using System.Collections;

public class AnimLoadLevel : MonoBehaviour {

    public MovieTexture anim;
	// Use this for initialization
	void Start () {
        renderer.material.mainTexture = anim;
        anim.Play();
        Invoke("nextScene", 5.05f);
        PlayerPrefs.DeleteAll();
    }

    void nextScene()
    {
        Application.LoadLevel("MainMenu");
    }
}
