using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	
	public GUITexture menu;
	private bool pause = false;
	
	void Start(){ 
		menu.enabled = false;
	}
	
	void Update () {
		if (Input.GetKey("escape")){
			if(pause == true){
				pause = false;
			}
		else{
			pause = true;
			}
		}
		
		if (pause == true){
			Time.timeScale = 0.0f;
			menu.enabled = true;
		}
		else{
			Time.timeScale = 1.0f;
			menu.enabled = false;
		}
	}
	
}
