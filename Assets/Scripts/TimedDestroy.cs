using UnityEngine;
using System.Collections;

public class TimedDestroy : MonoBehaviour {

    public int timer;
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, timer);
	
	}
	
}
