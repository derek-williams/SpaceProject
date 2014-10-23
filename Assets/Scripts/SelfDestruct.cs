using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour {

	// Use this for initialization
	void Start () {

        if (this.gameObject.tag != "EditorOnly")
        {
            Invoke("SelfDestroy", 60);
        }

        else Invoke("SelfDestroy", 3);

	}
	
	// Update is called once per frame
	void SelfDestroy () {
        Destroy(this.gameObject);
	}
}
