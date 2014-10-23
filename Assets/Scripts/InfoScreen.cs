using UnityEngine;
using System.Collections;

public class InfoScreen : MonoBehaviour {

    public GameObject infoScreen;
    public GameObject PMA;
    public GameObject MMA;
	// Use this for initialization
    void Start() {
        Time.timeScale = 0;
    }

	void Update () { 
        MMA.audio.mute = false;
        PMA.audio.mute = true;
        Screen.showCursor = true;
	}
	
	// Update is called once per frame
	void OnClick() {
            Time.timeScale = 1;
            Destroy(infoScreen);
	
	}
}
